//TODO: Update version number
document.querySelector("nav a.gitbook-link").remove();

gitbook.events.on('page.change', function () {
    $('td:contains("false")').addClass("bg-false"); 
    $('td:contains("true")').addClass("bg-true");
});