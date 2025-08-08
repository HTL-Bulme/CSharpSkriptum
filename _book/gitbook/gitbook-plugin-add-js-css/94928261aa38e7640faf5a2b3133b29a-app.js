//TODO: Update version number

gitbook.events.on('page.change', function () {


    $("td").filter(function () {
        return $(this).text() === "true";
    }).addClass("bg-true");


    $("td").filter(function () {
        return $(this).text() === "false";
    }).addClass("bg-false");


    document.querySelector("nav a.gitbook-link").remove();
});