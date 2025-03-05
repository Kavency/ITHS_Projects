function changeColour() {
    let min = 0;
    let max = 255;

    let r = Math.floor(Math.random() * (max - min + 1)) + min;;
    let g = Math.floor(Math.random() * (max - min + 1)) + min;;
    let b = Math.floor(Math.random() * (max - min + 1)) + min;;

    document.body.style.backgroundColor = "rgb(" + r + "," + g + "," + b + ")";
};

function getWindowHeight() {
    return window.innerHeight;
};

function getWindowWidth() {
    return window.innerWidth;
};