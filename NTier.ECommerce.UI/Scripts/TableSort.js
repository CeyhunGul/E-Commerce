$(document).querySelector('sortSelect').change(function() {

    var content = document.querySelector('#content');
    var els = Array.prototype.slice.call(document.querySelectorAll('#content > div'));
    var desc = document.querySelector('input').checked;
    var cls = $(this).children("option:selected").val();
    console.log(cls.toString);

    if (id === 'byPrice') {
        cls = 'price';
    }
    else if (id === 'byName') {
        cls = 'name';
    }
    els.sort(function (a, b) {
        na = parseInt(a.querySelector('.' + cls).innerHtml);
        nb = parseInt(b.querySelector('.' + cls).innerHtml);
        return desc ? (nb - na) : (na - nb});
    els.foreach(function (el) {
        content.appendChild(el);
    });
});