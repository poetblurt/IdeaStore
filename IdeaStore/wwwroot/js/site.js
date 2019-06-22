(function () {
    var jsmodel = {
        url: {
            getAll: './api/Idea'
        }
    }

    var loadGrid = () => {
        $('#idea-grid').empty();
        ideaData.forEach((item, index) => {
            if (index % 4 == 0) {
                $('#idea-grid').append(`<div class="row"><div>`);
            }
            $('#idea-grid').children().last().append(`
                <div class="col-md-3">
                    <div class="idea-icon">
                        <p data-title='${item.description}'>${item.name}</p>
                    </div>
                </div>`);
        });
    }

    var ideaData = [];
    loadGrid();

    $.ajax({
        url: jsmodel.url.getAll,
        success: (result) => {
            result.data.forEach((item) => {
                ideaData.push(item);
            });
            loadGrid();
        },
        error: (request) => {
            console.log(`${request.Message} ${request.Status}`);;
        }
    });


})();