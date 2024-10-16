using Microsoft.AspNetCore.Http;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Webp;

namespace FashionStore.Infrastructure.Middleware
{
    public class ImageHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ImageHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var path = context.Request.Path.Value;

            if (path.EndsWith(".avif"))
            {
                // Lấy đường dẫn thư mục hiện tại (base directory của ứng dụng)
                var baseDirectory = AppContext.BaseDirectory;

                // Xác định đường dẫn đầy đủ tới thư mục wwwroot/Images
                var wwwrootPath = Path.Combine(baseDirectory, "wwwroot", "Images");

                // Xây dựng đường dẫn đầy đủ tới file ảnh trong thư mục wwwroot/Images
                var fileName = Path.GetFileName(path);
                var filePath = Path.Combine(wwwrootPath, fileName);

                // Nếu file .avif tồn tại, chuyển đổi sang .webp
                if (File.Exists(filePath))
                {
                    try
                    {
                        using (SixLabors.ImageSharp.Image image = SixLabors.ImageSharp.Image.Load(filePath)) // Tải file .avif
                        {
                            // Tạo đường dẫn cho file .webp
                            var webpFilePath = Path.Combine(wwwrootPath, fileName.Replace(".avif", ".webp"));

                            // Nếu file .webp chưa tồn tại, chuyển đổi và lưu file
                            if (!File.Exists(webpFilePath))
                            {
                                // Chuyển đổi ảnh sang định dạng WebP với chất lượng tùy chọn
                                var encoder = new WebpEncoder()
                                {
                                    Quality = 75 // Đặt chất lượng ảnh WebP, giá trị từ 0 đến 100
                                };
                                image.Save(webpFilePath, encoder); // Lưu ảnh với định dạng WebP
                            }

                            // Trả về file .webp đã chuyển đổi
                            var imageBytes = await File.ReadAllBytesAsync(webpFilePath);
                            context.Response.ContentType = "image/webp";
                            await context.Response.Body.WriteAsync(imageBytes, 0, imageBytes.Length);
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Lỗi khi chuyển đổi ảnh: {ex.Message}");
                    }
                }
            }

            await _next(context);
        }
    }
}
