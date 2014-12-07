<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebAutos.aspx.cs" Inherits="WebAutos.WebAutos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="js/jquery-2.1.1.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Marca : <input type="text" id="marca" />
        Modelo : <input type="text" id="modelo" />
        Chasis : <input type="text" id="chasis" />
        Color : <input type="text" id="color" />
        Tipo : <select id="tipo">
            <option value="Hach Back">Hach Back</option>
            <option value="Sedan">Sedan</option>
            <option value="4X4">4X4</option>
            <option value="Camioneta">Camioneta</option>
        </select>        
        <input type="button" value="Grabar" id="enviar" />
                <input type="button" value="Traer" id="traer" />

        <table id="registro"></table>
    
    </div>
        
        <script>

            $(document).ready(function() {

                $("#enviar").click(function() {
                    
                   

                         var data = "{'marca':'" + $("#marca").val() + "','modelo':'" + $("#modelo").val() + "','chasis':'" + $("#chasis").val() + "','color':'" + $("#color").val() + "','tipo':'" + $("#tipo").val() + "'}";
                            $.ajax({
                                url: "WebAutos.aspx/Grabar",
                                data: data,
                                contentType: "application/json; charset=utf-8",
                                dataType: "json",
                                type: "POST",
                                success: function (msj) { alert(msj.d); },
                                error: function (result) { }
                            });


                });
                $("#traer").click(function () {



                    var data = "";
                    $.ajax({
                        url: "WebAutos.aspx/listar",
                        data: data,
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        type: "POST",
                        success: function (msj) {
                        alert("N° de registros : "+ msj.d.length);
                        for (var i = 0; i < msj.d.length; i++) {
                            //alert("Marca : " + msj.d[i].Marca);
                            $("#registro").append("<tr><td>" + msj.d[i].Marca + "</td><td>" + msj.d[i].Modelo + "</td><td>" + msj.d[i].Chasis + "</td><td>" + msj.d[i].Color + "</td><td>" + msj.d[i].Tipo + "</td></tr>")
                        }
                        },
                        error: function (result) { } 
                    }); 


                });

               

            });








        </script>
        
        

    </form>
    

</body>
</html>
