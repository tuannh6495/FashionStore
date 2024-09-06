const slider = document.querySelector('.price-slider');
const minHandle = document.getElementById('minHandle');
const maxHandle = document.getElementById('maxHandle');
const range = document.querySelector('.slider-range');
const minPrice = document.getElementById('minPrice');
const maxPrice = document.getElementById('maxPrice');

let isDragging = null;

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
    const minValue = Math.round(50 + (minPos * 150));
    const maxValue = Math.round(50 + (maxPos * 150));
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

minHandle.addEventListener('mousedown', startDragging);
maxHandle.addEventListener('mousedown', startDragging);
document.addEventListener('mousemove', drag);
document.addEventListener('mouseup', stopDragging);

// Initialize handle positions
setHandlePosition(minHandle, slider.getBoundingClientRect().left + 51);  // 51px from left as in SVG
setHandlePosition(maxHandle, slider.getBoundingClientRect().right - 50); // 50px from right as in SVG
updateRange();
updatePrices();

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