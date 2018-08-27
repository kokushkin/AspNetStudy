<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_5_7.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function GetTerritories(regionID)
        {
              _5_7.TerritoriesService.GetTerritoriesInRegion(regionID, OnRequestComplete, OnError);
        }
        function OnRequestComplete(result) {
            //var lstTerritories = document.getElementById("lstTerritories");
            var lstTerritories = $get("lstTerritories");
            lstTerritories.innerHTML = "";

            for (var n = 0; n < result.length; n++) {
                var option = document.createElement("option");
                option.value = result[n].ID;
                option.innerHTML = result[n].Description;
                lstTerritories.appendChild(option);
            }
        }
        function OnError(result) {
            var lbl = document.getElementById("lblInfo");
            lbl.innerHTML = "<b>" + result.get_message() + "</b><br>";
            lbl.innerHTML += result.get_stackTrace();
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
                <Services>
                    <asp:ServiceReference Path="~/TerritoriesService.asmx"/>
                </Services>
            </asp:ScriptManager>
            <asp:DropDownList ID="lstRegions" runat="server" Width="210px" DataSourceID="sourceRegions"
                DataTextField="RegionDescription" DataValueField="RegionID"
                onchange="GetTerritories(this.value);" />
            <asp:DropDownList ID="lstTerritories" runat="server" Width="275px" />
            <asp:SqlDataSource ID="sourceRegions" runat="server" ConnectionString="<%$ ConnectionStrings:Northwind %>"
                SelectCommand="SELECT 0 As RegionID, '' AS RegionDescription UNION SELECT RegionID, RegionDescription FROM Region" />
            <asp:Label ID="lblInfo" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
