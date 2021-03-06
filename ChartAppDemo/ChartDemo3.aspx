<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChartDemo3.aspx.cs" Inherits="ChartAppDemo.ChartDemo3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="border: 1px solid black; font-family: Arial">
<tr>
    <td>
        <b>Select Chart Type:</b>
    </td>
    <td>
        <asp:DropDownList ID="DropDownList1" AutoPostBack="true" runat="server"
            OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
    </td>
</tr>
<tr>
    <td colspan="2">
        <asp:Chart ID="Chart1" runat="server" Width="350px">
            <Titles>
                <asp:Title Text="Total marks of students">
                </asp:Title>
            </Titles>
            <Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                    <AxisX Title="Student Name">
                    </AxisX>
                    <AxisY Title="Total Marks">
                    </AxisY>
                    <Area3DStyle Enable3D="true" WallWidth="20" />
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
    </td>
</tr>
</table>
</asp:Content>
