<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChartDemo4.aspx.cs" Inherits="ChartAppDemo.ChartDemo4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<table style="border: 1px solid black; font-family: Arial">
<tr>
    <td colspan="2">
        <asp:Chart ID="Chart1" runat="server" Width="350px">
            <Titles>
                <asp:Title Text="Total marks of students">
                </asp:Title>
            </Titles>
            <Series>
                <asp:Series Name="Series1">
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                    <AxisX Title="Student Name">
                    </AxisX>
                    <AxisY Title="Total Marks">
                    </AxisY>
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
    </td>
</tr>
</table>
</asp:Content>
