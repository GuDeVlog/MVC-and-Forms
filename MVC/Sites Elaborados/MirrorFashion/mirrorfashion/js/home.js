document.querySelector('#form-busca').onsubmit = function() {
    if (document.querySelector('#q').value == '') {
        document.querySelector('.busca form').style.background = 'red';
        return false;
    }
};

var banners = ["img/destaque-home.png", "img/destaque-home-2.png"];
var varBanner = 0;

function switchBanner() {
    varBanner = (varBanner + 1) % 2;
    document.querySelector('.destaque img').src = banners[varBanner];
}
var timer = setInterval(switchBanner, 4000);
var ctrl = document.querySelector('.pause');

ctrl.onclick = function() {
    if (ctrl.className == 'pause') {
        clearInterval(timer);
        ctrl.className = 'play';
    } else {
        timer = setInterval(switchBanner, 4000);
        ctrl.className = 'pause';
    }
    return false;
};
