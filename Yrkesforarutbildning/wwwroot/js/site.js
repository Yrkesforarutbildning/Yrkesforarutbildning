const hamburger = document.querySelector('.hamburger');
const mobileMenu = document.querySelector('.mobile-menu');
const closeMenu = document.querySelector('.close-menu');

hamburger.addEventListener('click', () => {
    mobileMenu.style.display = 'flex';
});

closeMenu.addEventListener('click', () => {
    mobileMenu.style.display = 'none';
});