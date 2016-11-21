$(function () {
    $.connection.hub.url = "http://test2305.somee.com/signalr";//http://localhost:8080

    var chat = $.connection.chatHub;

    chat.client.addMessage = function (name, msg) {
        alert(name+" "+msg);
        $('#discussion').append('<li><strong>' + name
                + '</strong>:&nbsp;&nbsp;' + msg + '</li>');
    };

    $('#displayname').val(prompt('Enter your name:', ''));

    $('#message').focus();

    $.connection.hub.start()
        .done(
            function () {
                alert("Done");
                chat.server.connect($('#displayname').val());
                $('#sendmessage').click(function () {
                    alert("Send");
                    chat.server.sendMessage($('#message').val());
                    $('#message').val('').focus();
                });
            })
        .fail(function (reason) {
            alert("Error");
            console.log("SignalR connection failed: " + reason);
        });
    alert("Connect");
});