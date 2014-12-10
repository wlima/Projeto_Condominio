function poptastic(url) {
    newwindow = window.open(url, 'name', 'height=400,width=200');
    if (window.focus) { newwindow.focus() }
}