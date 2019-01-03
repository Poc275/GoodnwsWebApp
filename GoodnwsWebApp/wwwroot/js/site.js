// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
fetch('/Home/GetTotalNumberOfArticles').then(function (response) {
    return response.json();
}).then(function (total) {
    nPages = Math.ceil(total / 10);

    // now we know the total number of pages to fetch, instantiate infinite scrolling
    var infScroll = new InfiniteScroll('.root', {
        // options
        path: function () {
            if (this.loadCount < nPages) {
                return '/Home/GetMoreArticles?page=' + this.loadCount;
            }
        },
        append: '.story',
        status: '.scroller-status'
    });
});