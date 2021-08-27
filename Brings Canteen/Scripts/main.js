var slider = 50;
var state = true;
var bgAnimatorCallback = function () { // bgAnimatorCallback will be called at every interval
    if (slider > 100) {
        state = false;
    }
    else if (slider <= 40) {
        state = true
    }
    // Use state to determine if to increase slider or decrease it
    var currentValue = state ? slider++ : slider--;
    document.documentElement.style.setProperty('---jumbo-slider-end', currentValue + "%");
}

setInterval(bgAnimatorCallback, 80);


function registerServiceWorker() {
    if ('serviceWorker' in navigator) {
        navigator.serviceWorker.register(
          '/sw.js',
          { scope: '/' })
        .then(function () { console.log("Service Worker Registered") })
        .catch(function () { console.log("Service worker was not registered") })
    }
}

registerServiceWorker();