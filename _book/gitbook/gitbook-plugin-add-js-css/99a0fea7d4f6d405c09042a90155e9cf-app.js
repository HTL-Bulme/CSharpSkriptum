//TODO: Update version number
let newParam = "v=2024-11-08";

document.querySelector("nav a.gitbook-link").remove();
let links = document.querySelectorAll("nav a");

links.forEach(linkElement => {
    let currentHref = linkElement.href;

    if (currentHref.includes('?')) {
        query = '&' + newParam;
    }
    else {
        query = '?' + newParam;
    }

    currentHref += query;
    linkElement.href = currentHref;
});