
export function getDimensions()
{
    return {
        width: window.innerWidth,
        height: window.innerHeight
    };
};

export function getNewDimension() {
    return {
        width: document.getElementById("window_inner_width").innerHTML,
        height: document.getElementById("window_inner_height").innerHTML
    };
};
// E Get Width and Height

// S window.onresize
window.onresize = resizer;
export function resizer()
{
    document.getElementById("window_inner_width").innerHTML = window.innerWidth;
    document.getElementById("window_inner_height").innerHTML = window.innerHeight;

    document.getElementById("inner_width").innerHTML = document.getElementById("window_inner_width").innerHTML;
    document.getElementById("inner_height").innerHTML = document.getElementById("window_inner_height").innerHTML;
}
export function resize()
{
    return window.onresize;
}
// E window.onresize

// S addEventListener
export function onWindowSizeHandle()
{
    document.querySelector('.width').innerText = window.innerWidth;
    document.querySelector('.height').innerText = window.innerHeight;
}
export function onWindowSize()
{
    return window.addEventListener('resize', onWindowSizeHandle);
}
// E addEventListener
