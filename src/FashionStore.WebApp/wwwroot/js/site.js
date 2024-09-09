const slider = document.querySelector('.price-slider');
const minHandle = document.getElementById('minHandle');
const maxHandle = document.getElementById('maxHandle');
const range = document.querySelector('.slider-range');
const minPrice = document.getElementById('minPrice');
const maxPrice = document.getElementById('maxPrice');
let isDragging = null;

const MIN_PRICE = 0;
const MAX_PRICE = 250;
const DEFAULT_MIN = 50;
const DEFAULT_MAX = 200;

function setHandlePosition(handle, position) {
    const sliderRect = slider.getBoundingClientRect();
    let newPosition = (position - sliderRect.left) / sliderRect.width;
    newPosition = Math.max(0, Math.min(newPosition, 1));
    handle.style.left = `${newPosition * 100}%`;
    return newPosition;
}

function updateRange() {
    const minPos = parseFloat(minHandle.style.left);
    const maxPos = parseFloat(maxHandle.style.left);
    range.style.left = `${minPos}%`;
    range.style.width = `${maxPos - minPos}%`;
}

function updatePrices() {
    const minPos = parseFloat(minHandle.style.left) / 100;
    const maxPos = parseFloat(maxHandle.style.left) / 100;
    const minValue = Math.round(MIN_PRICE + (minPos * (MAX_PRICE - MIN_PRICE)));
    const maxValue = Math.round(MIN_PRICE + (maxPos * (MAX_PRICE - MIN_PRICE)));
    minPrice.textContent = `$${minValue}`;
    maxPrice.textContent = `$${maxValue}`;
    minPrice.style.left = minHandle.style.left;
    maxPrice.style.left = maxHandle.style.left;
}

function startDragging(e) {
    isDragging = e.target;
}

function stopDragging() {
    isDragging = null;
}

function drag(e) {
    if (!isDragging) return;
    const newPos = setHandlePosition(isDragging, e.clientX);
    if (isDragging === minHandle && newPos > parseFloat(maxHandle.style.left) / 100) {
        setHandlePosition(minHandle, maxHandle.getBoundingClientRect().left);
    } else if (isDragging === maxHandle && newPos < parseFloat(minHandle.style.left) / 100) {
        setHandlePosition(maxHandle, minHandle.getBoundingClientRect().left);
    }
    updateRange();
    updatePrices();
}

function initializeSlider() {
    const minPos = (DEFAULT_MIN - MIN_PRICE) / (MAX_PRICE - MIN_PRICE);
    const maxPos = (DEFAULT_MAX - MIN_PRICE) / (MAX_PRICE - MIN_PRICE);
    setHandlePosition(minHandle, slider.getBoundingClientRect().left + minPos * slider.offsetWidth);
    setHandlePosition(maxHandle, slider.getBoundingClientRect().left + maxPos * slider.offsetWidth);
    updateRange();
    updatePrices();
}

minHandle.addEventListener('mousedown', startDragging);
maxHandle.addEventListener('mousedown', startDragging);
document.addEventListener('mousemove', drag);
document.addEventListener('mouseup', stopDragging);

// Initialize the slider when the page loads
window.addEventListener('load', initializeSlider);

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