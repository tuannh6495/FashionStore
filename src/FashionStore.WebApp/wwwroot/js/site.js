document.addEventListener('DOMContentLoaded', function () {
    const slider = document.getElementById('rangeSlider');
    const minValueDisplay = document.getElementById('minValue');
    const maxValueDisplay = document.getElementById('maxValue');

    // Cập nhật giá trị hiển thị khi người dùng thay đổi thanh trượt
    slider.addEventListener('input', function () {
        const value = slider.value;
        minValueDisplay.textContent = value;
        maxValueDisplay.textContent = value;
    });
});
