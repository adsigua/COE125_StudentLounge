<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="COE125._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div class="main">
            <div class="section">
                <div class="container tim-container">
                    <h1>ASP.NET</h1>
                    <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
                    <p><textarea name="editor1" id="editor1" rows="10" cols="80"></textarea></p>
                    <button href="http://www.asp.net" class="btn btn-fill btn-danger">Learn more</button>
                    <script>
                        CKEDITOR.replace( 'editor1' );
                    </script>
                </div>
            </div>
        </div>
</asp:Content>
