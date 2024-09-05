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