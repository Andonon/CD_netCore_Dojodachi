$(document).ready(function(){ 



    $( "#feed" ).click(function() {
        $.get("/feed", function(response){
            //response handling here
        });
    });
    $( "#play" ).click(function() {
    alert( "Handler for .click(play) called." );
    });
    $( "#work" ).click(function() {
    alert( "Handler for .click(work) called." );
    });
    $( "#sleep" ).click(function() {
    alert( "Handler for .click(sleep) called." );
    });


});