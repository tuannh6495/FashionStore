document.addEventListener('DOMContentLoaded', () => {
    // Lấy tất cả các phần tử product-photo
    const photos = document.querySelectorAll('.product-photo');

    photos.forEach(photo => {
        photo.addEventListener('click', () => {
            // Loại bỏ lớp selected từ tất cả các phần tử
            photos.forEach(p => p.classList.remove('selected'));
            // Thêm lớp selected vào phần tử được nhấp
            photo.classList.add('selected');
        });
    });
});

document.addEventListener('DOMContentLoaded', () => {
    const photos = document.querySelectorAll('.product-photo');
    const mainPhoto = document.querySelector('.product-main-photo');

    photos.forEach(photo => {
        photo.addEventListener('click', () => {
            photos.forEach(p => p.classList.remove('selected'));
            photo.classList.add('selected');

            const backgroundImage = getComputedStyle(photo).backgroundImage;
            mainPhoto.style.backgroundImage = backgroundImage;
        });
    });
});


function selectColor(element) {
    // Bỏ tích từ các màu trước đó
    var circles = document.querySelectorAll('.circle');
    circles.forEach(function (circle) {
        circle.classList.remove('selected');
        var tick = circle.querySelector('.tick');
        if (tick) tick.remove();
    });

    // Thêm tích vào màu được chọn
    element.classList.add('selected');
    var tickImage = document.createElement('img');
    tickImage.src = '/Images/Tick.png'; // Đường dẫn đến ảnh tick
    tickImage.classList.add('tick');
    element.appendChild(tickImage);
}

document.addEventListener("DOMContentLoaded", function () {
    const sizeBoxes = document.querySelectorAll('.size-box');

    sizeBoxes.forEach(box => {
        box.addEventListener('click', function () {
            // Loại bỏ class 'selected' khỏi tất cả các ô
            sizeBoxes.forEach(b => b.classList.remove('selected'));

            // Thêm class 'selected' vào ô được nhấp
            this.classList.add('selected');
        });
    });
});


//sử lý số tăng giảm
// Lấy các phần tử cần thao tác
const minusButton = document.getElementById("minus-button");
const plusButton = document.getElementById("plus-button");
const quantityDisplay = document.getElementById("quantity-display");

// Mặc định số lượng là 1
let quantity = 1;

// Hàm cập nhật số lượng hiển thị
function updateQuantityDisplay() {
    quantityDisplay.textContent = quantity;
}

// Xử lý khi bấm vào dấu trừ
minusButton.addEventListener("click", function () {
    if (quantity > 0) {
        quantity--;
        updateQuantityDisplay();
    }
});

// Xử lý khi bấm vào dấu cộng
plusButton.addEventListener("click", function () {
    quantity++;
    updateQuantityDisplay();
});