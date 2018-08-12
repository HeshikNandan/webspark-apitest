

$(document).ready(function () {
    var displayBlockList = new DisplayBlockList();
    displayBlockList.init();
});


function DisplayBlockList() {
    this.displayBlockList = [];
    this.getDisplayBlockUrl = "api/displayBlock";
    this.content = $(".display-block-content-row");
}

DisplayBlockList.prototype = {
    init : function() {
        var el = this;
         $.ajax({
            type: 'GET',
            url: el.getDisplayBlockUrl,
            success: function (data) {
                    el.clearContent();
                    data.forEach(function(dB) {
                        var displayBlock = new DisplayBlock(dB, el.content);
                        el.displayBlockList.push(displayBlock);
                    });
                }
            });
    },
    clearContent : function() {
            var el = this;
            el.content.empty();
            el.displayBlockList = [];
        
    } 
}

function DisplayBlock(displayBlock, parentBody) {
    this.parentBody = parentBody;
    this.id = displayBlock.id;
    this.title = displayBlock.title;
    this.description = displayBlock.description;
    this.categoryName = displayBlock.categoryName;
    this.imageUrl = displayBlock.imageUrl;
    this.redirectUrl = displayBlock.redirectUrl;
    this.htmlSkeleton = "<div class='display-block-content col-md-4 col-sm-4 col-lg-4'><img class='display-block-image' src='" + this.imageUrl + "'>" +
                    "<div class='caption'><h3 class='title'>" + this.title + "</h3>" +
                        "<p class='description'>" + this.description + "</p><div class='bottom-content'><h5 class='category display-block-category'><span class='glyphicon glyphicon-option-vertical'/>" + this.categoryName + "</h5></div>" +
                    "</div></div>";
    this.init();
}

DisplayBlock.prototype = {
    init: function() {
        var el = this;
        var renderedHtml = $(el.htmlSkeleton);
        renderedHtml.click(function() {
            window.open(el.redirectUrl, '_blank');
        });
        el.parentBody.append(renderedHtml);
    }
}