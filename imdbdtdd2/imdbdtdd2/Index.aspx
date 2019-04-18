<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="imdbdtdd2.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label>Enter Movie: </label><br/>
            <Asp:textbox runat="server" id="inputmovie"></Asp:textbox> <asp:button runat="server" text="Go" ID="btnsubmit" OnClick="btnsubmit_Click" /><br />
            <div id="imdbdata">
                <div id="deets" style="float:left">
                    <asp:Label ID="Label1" runat="server" Text="Title: "></asp:Label> 
                    <asp:Label ID="lblname" runat="server" Text=""></asp:Label> <br />
                     <asp:Label ID="Label2" runat="server" Text="Year: "></asp:Label> 
                    <asp:Label ID="lblyear" runat="server" Text=""></asp:Label>
                     <asp:Label ID="Label3" runat="server" Text="Rated: "></asp:Label> 
                    <asp:Label ID="lblrated" runat="server" Text=""></asp:Label> <br />
                     <asp:Label ID="Label4" runat="server" Text="Director(s): "></asp:Label> 
                    <asp:Label ID="lbldirector" runat="server" Text=""></asp:Label>
                     <asp:Label ID="Label5" runat="server" Text="Cast: "></asp:Label> 
                    <asp:Label ID="lblactors" runat="server" Text=""></asp:Label><br />
                     <asp:Label ID="Label6" runat="server" Text="Plot: "></asp:Label> 
                    <asp:Label ID="lblplot" runat="server" Text=""></asp:Label> 
</div>
                

     
                <div id="poster" style="float:right" ><asp:Image ID="imgposter" runat="server"  /></div>

                
            </div>
        </div>
    </form>
</body>
</html>
