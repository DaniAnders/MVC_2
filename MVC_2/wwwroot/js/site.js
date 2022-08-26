
function ListPeople() {

        $.ajax({
            type: "GET",
            url: "Ajax/ListPeople",
            success: function (response) {
                $("#div-partial").html(response);
            },
            error: function () {
                alert("error");
            }
        });
    
}



function DeleteById() {
    var inputId = $("#id").val();

    $.ajax({
        type: "POST",
        url: "Ajax/Delete?id="+inputId,
        success: function (response) {
            $("#div-partial").html(response);
            document.getElementById("message").innerHTML = "The user was removed from the list";
        },
        error: function () {
            alert("error");
        }
    });

}

function DetailsById() {
    var inputId = $("#id").val();

    $.ajax({
        type: "POST",
        url: "Ajax/Details?id=" + inputId,
        success: function (response) {
            $("#div-partial").html(response);
        },
        error: function () {
            alert("error");
        }
    });

}



/*function changecolor() {
    $("p").css({ "color": "red" })
}

changecolor();*/


