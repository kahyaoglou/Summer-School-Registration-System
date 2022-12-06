<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OgrenciGuncelle.aspx.cs" Inherits="Summer_School_Registration_System.OgrenciGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="form-group">
            <div>
                <!--Tasarım olarak gruplara ayırma.-->
                <asp:Label for="txtID" runat="server" Text="Öğrenci ID:" style="font-weight: bold"></asp:Label>
                <!-- for="TextBox1". o öğe, textbox1 için çalışacak demektir-->
                <asp:TextBox ID="txtID" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <!--Tasarım olarak gruplara ayırma.-->
                <asp:Label for="txtAd" runat="server" Text="Öğrenci Adı:" style="font-weight: bold"></asp:Label>
                <!-- for="TextBox1". o öğe, textbox1 için çalışacak demektir-->
                <asp:TextBox ID="txtAd" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="txtSoyad" runat="server" Text="Öğrenci Soyadı:" style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="txtSoyad" runat="server" CssClass="form-control"></asp:TextBox>
                <!--Css Class ile css kullanırız. Bunun için de bootstrapin nimetlerinden faydalanırız.-->
            </div>
            <br />
            <div>
                <asp:Label for="txtNumara" runat="server" Text="Öğrenci Numara:" style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="txtNumara" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="txtSifre" runat="server" Text="Öğrenci Şifre:" style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="txtSifre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="txtFotograf" runat="server" Text="Öğrenci Fotoğraf:" style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="txtFotograf" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-warning"/>
    </form>
</asp:Content>




