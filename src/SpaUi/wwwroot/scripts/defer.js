const placeHolders = document.getElementsByClassName('imgPlaceholder');

for (let i = 0; i < placeHolders.length; i++) {
    const imgLarge = new Image();
    imgLarge.src = placeHolders[i].dataset.large;
    imgLarge.onload = function() {
        imgLarge.classList.add('loaded');
    };
    placeHolders[i].parentElement.appendChild(imgLarge);
}