<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Kaydol.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style6
    {
        width: 589px;
    }
    .style7
    {
        width: 176px;
        height: 49px;
    }
    .style8
    {
        width: 358px;
        height: 49px;
    }
    .style11
    {
        width: 176px;
        height: 55px;
    }
    .style12
    {
        width: 358px;
        height: 55px;
    }
    .style13
    {
        width: 176px;
        height: 54px;
    }
    .style14
    {
        width: 358px;
        height: 54px;
    }
    .style15
    {
        width: 176px;
    }
    .style16
    {
        width: 358px;
    }
</style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="divkaydolbanner"></div>
<br />
<div class="divtable">
   <BR /> 
    <SPAN style="border-style: none; border-width: thin; border-color: #FFFFFF; font-size: 45px; font-weight: lighter; font-family: 'Bookman Old Style'">KAYIT FORMU</SPAN> 
    <hr style="border-color: #FFA500; font-size: xx-small; color: #FFA500; background-color: #FFA500;" 
        width="350px" /><br />
    <br />
    <table class="style6" 
        style="text-align: left; margin-left: 425px; color: #FF5050; font-size: x-large;">
        <tr>
            <td class="style7" style="color: #FF3300; font-weight: bold;">
&nbsp;&nbsp;&nbsp;&nbsp; Adı Soyadı:</td>
            <td class="style8" style="color: #000000">
                <asp:TextBox ID="txtadsoyad" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style13" style="color: #FF3300; font-weight: bold;">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; E-mail:</td>
            <td class="style14" style="color: #000000">
                <asp:TextBox ID="txtmail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style11" style="color: #FF3300; font-weight: bold;">
                Kullanıcı Adı:</td>
            <td class="style12" style="color: #000000">
                <asp:TextBox ID="txtkadi" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style13" style="color: #FF3300; font-weight: bold;">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Şifre:</td>
            <td class="style14" style="color: #000000">
                <asp:TextBox ID="txtsifre" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style15">
                &nbsp;</td>
            <td class="style16">
&nbsp;&nbsp;
            </td>
        </tr>
        <tr>
            <td class="style15">
                &nbsp;</td>
            <td class="style16">
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" CssClass="başka" 
                    onclick="Button1_Click" Text="Kayıt Ol" Width="129px" />
                <br />
                <br />
                <asp:Label ID="Label1" runat="server" ForeColor="White"></asp:Label>
            </td>
        </tr>
    </table>
    <br />
    <br />
    </div>
</asp:Content>

