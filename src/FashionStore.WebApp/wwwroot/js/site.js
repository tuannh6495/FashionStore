// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const minusBtn = document.getElementById('minus-btn');
const plusBtn = document.getElementById('plus-btn');
const quantityDisplay = document.getElementById('quantity');

let quantity = 1; // Mặc định số là 1

minusBtn.addEventListener('click', () => {
    if (quantity > 1) { // Giới hạn số không được nhỏ hơn 1
        quantity--;
        quantityDisplay.textContent = quantity;
    }
});

plusBtn.addEventListener('click', () => {
    quantity++;
    quantityDisplay.textContent = quantity;
});
