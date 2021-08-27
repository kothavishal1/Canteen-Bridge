var button = document.querySelector("#themeBtn")
var themeSwitch = 1;
button.addEventListener('click', function (event) {

    switch (themeSwitch) {
        case 1: applyTheme(themeSwitch); themeSwitch = 2;
            break;
        case 2: applyTheme(themeSwitch); themeSwitch = 3;
            break;
        case 3: applyTheme(themeSwitch); themeSwitch = 1;
            break;
    }
});

function applyTheme(position) {
    if (position == 1) {
        document.documentElement.style.setProperty('---jumbotron-bg-start', 'rgba(187, 60, 252, 1)');
        document.documentElement.style.setProperty('---jumbotron-bg-end', 'rgba(187, 108, 252, .5)');
        document.documentElement.style.setProperty('---nav-bg-color', 'rgba(187, 60, 252, 1)');
        document.documentElement.style.setProperty('---background-color', 'rgba(187, 60, 252, 1)');
        document.documentElement.style.setProperty('---bg-color-list-odd', 'rgba(187, 60, 252, .2)');
        document.documentElement.style.setProperty('---bg-color-list-even', 'rgba(187, 60, 252, .7)');
        document.documentElement.style.setProperty('---card-bg-hover-color', 'rgba(187, 60, 252, .6)');
        document.documentElement.style.setProperty('---nav-hover-color', 'black');
        document.documentElement.style.setProperty('---jumbo-text', 'black');
    }
    else if (position == 2) {
        document.documentElement.style.setProperty('---jumbotron-bg-start', 'rgba(217, 83, 79, 1)');
        document.documentElement.style.setProperty('---jumbotron-bg-end', 'rgba(217, 83, 79, .5)');
        document.documentElement.style.setProperty('---nav-bg-color', 'rgba(217, 83, 79, 1)');
        document.documentElement.style.setProperty('---background-color', 'rgba(217, 83, 79, 1)');
        document.documentElement.style.setProperty('---bg-color-list-odd', 'rgba(217, 83, 79, .2)');
        document.documentElement.style.setProperty('---bg-color-list-even', 'rgba(217, 83, 79, .7');
        document.documentElement.style.setProperty('---card-bg-hover-color', 'rgba(217, 83, 79, .6)');
        document.documentElement.style.setProperty('---nav-hover-color', 'black');
        document.documentElement.style.setProperty('---jumbo-text', 'black');
    } else if (position == 3) {
        document.documentElement.style.setProperty('---jumbotron-bg-start', 'rgba(0, 0, 0, 0)');
        document.documentElement.style.setProperty('---jumbotron-bg-end', 'rgba(0,0,0,0)');
        document.documentElement.style.setProperty('---nav-bg-color', 'rgba(0,0,0,0)');
        document.documentElement.style.setProperty('---background-color', 'rgba(0,0,0,0)');
        document.documentElement.style.setProperty('---bg-color-list-odd', 'rgba(0,0,0,0)');
        document.documentElement.style.setProperty('---bg-color-list-even', 'rgba(0,0,0,0)');
        document.documentElement.style.setProperty('---card-bg-hover-color', 'rgba(0,0,0,0)');
        document.documentElement.style.setProperty('---nav-hover-color', 'white');
        document.documentElement.style.setProperty('---jumbo-text', 'white');
    }
}

