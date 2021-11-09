<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChartAppDemo._Default" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

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
                <asp:Series Name="Series1" ChartArea="ChartArea1" ChartType="Pie">
                    <Points>
                        <asp:DataPoint AxisLabel="Mark" YValues="-800" />
                        <asp:DataPoint AxisLabel="Steve" YValues="900" />
                        <asp:DataPoint AxisLabel="John" YValues="700" />
                        <asp:DataPoint AxisLabel="Mary" YValues="900" />
                        <asp:DataPoint AxisLabel="Ben" YValues="600" />
                    </Points>
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
