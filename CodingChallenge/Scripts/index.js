// Método para realizar la llamada al servicio de obtención
// de los titulos por descripción.
var dataSource = function (query, process) {
    $.ajax({
        url: '/api/WebApiTitulos',
        type: "GET",
        data: { term: query }
    })
        .done(function (response) {
            return process(response);
        });
};

// Método para realizar la llamada al backend y obtener
// los datos de un titulo por id.
var getItemData = function (item) {
    $.ajax({
        url: '/Titulos/GetTitulo',
        type: "GET",
        data: { id: item.id }
    })
        .done(function (response) {
            var divDetails = $("#titulo-detail");

            divDetails.show();
            divDetails.html(response);
            styleMonedaInput();
        });
};

// Método encargado de separar el valor de la enumeración Moneda de
// Titulo, y asi mostrar un nombre mas acorde en el campo input de la vista.
var styleMonedaInput = function () {
    var monedaInput = $("input").last();
    var sections = monedaInput.val().split("A");
    var newValue = sections[0] + " A" + sections[1];

    monedaInput.val(newValue);
};

// Inicialización del plugin autocomplete.
$(function () {
    $('#input-titulos').typeahead({
        autoSelect: true,
        minLength: 1,
        delay: 300,
        items: "all",
        source: dataSource,
        afterSelect: getItemData
    });
});