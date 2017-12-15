<%@ Page Language="C#" %>

<!DOCTYPE html>

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    Eu existo!
    <form id="form1" runat="server">
        <div>
            <%
                
                string json;
                using(var reader = new System.IO.StreamReader(Request.InputStream)){
                    json = reader.ReadToEnd();
                }
                Response.Write(json);

                //var person = Json.Decode(json);
           %>
        <asp:

      <asp:sqldatasource id="SqlDataSource1"  
        selectcommand="Select * From [usuario]"
        updatecommand="Update usuario SET nick=@nick WHERE (id_usuario = @id_usuario)"
        deletecommand="Delete from usuario where id_usuario = @id_usuario"
        connectionstring="jdbc:mysql://127.0.0.1:8080/vilaanimalbanco"
        runat="server">
      </asp:sqldatasource>
        </div>
    </form>
    <script src="js/jquery-3.2.1.min.js"></script>
    <script>
        function getJson(insertingItem) {
            $http({
                method: post,
                url: "safgsa",
                data: insertingItem
            }).then(function (Response)){
                insertingItem = response.data[0];
                var1.push(insertingItem);
            }, function(error) {
                Console.log(error);
            }
    </script>
</body>
</html>
