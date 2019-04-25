<html>
<body> 
    <form id="form1" runat="server">  
    <div> 
        <strong><span style="font-size: 16pt; color: #009900">Manual Insert/Update/Delete Using  
            Auto-Generated EditForm</span></strong><br /> 
        <br /> 
        <radG:RadGrid ID="RadGrid1"  runat="server" Skin="Lime" 
            GridLines="None" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" 
            Width="97%" OnNeedDataSource="RadGrid1_NeedDataSource" OnDeleteCommand="RadGrid1_DeleteCommand" OnInsertCommand="RadGrid1_InsertCommand" OnUpdateCommand="RadGrid1_UpdateCommand" EnableAJAX="True"  > 
            <PagerStyle Mode="NextPrevAndNumeric"></PagerStyle> 
              
            <MasterTableView DataKeyNames="EmployeeID" GridLines="None" Width="100%" CommandItemDisplay ="Top" > 
              
                <Columns> 
                    <radG:GridButtonColumn CommandName="Delete" Text="Delete" UniqueName="Delete">  
                    </radG:GridButtonColumn> 
                    <radG:GridBoundColumn DataField="EmployeeID" HeaderText="EmployeeID" UniqueName="EmployeeID" ReadOnly="True">  
                    </radG:GridBoundColumn> 
                    <radG:GridBoundColumn DataField="LastName" HeaderText="LastName" UniqueName="LastName">  
                    </radG:GridBoundColumn> 
                    <radG:GridBoundColumn DataField="FirstName" HeaderText="FirstName" UniqueName="FirstName">  
                    </radG:GridBoundColumn> 
                    <radG:GridBoundColumn DataField="Title" HeaderText="Title" UniqueName="Title">  
                    </radG:GridBoundColumn> 
                    <radG:GridBoundColumn DataField="Address" HeaderText="Address" UniqueName="Address">  
                    </radG:GridBoundColumn> 
                    <radG:GridBoundColumn DataField="City" HeaderText="City" UniqueName="City">  
                    </radG:GridBoundColumn> 
                    <radG:GridEditCommandColumn> 
                    </radG:GridEditCommandColumn> 
                </Columns> 
                <EditFormSettings ColumnNumber="2" CaptionFormatString="Edit details for employee with ID {0}" 
                    CaptionDataField="EmployeeID">  
                    <FormTableItemStyle Wrap="False"></FormTableItemStyle> 
                    <FormCaptionStyle CssClass="EditFormHeader"></FormCaptionStyle> 
                    <FormMainTableStyle CellSpacing="0" CellPadding="3" Width="100%" /> 
                    <FormTableStyle GridLines="Horizontal" CellSpacing="0" CellPadding="2" CssClass="module" 
                        Height="110px" Width="100%" /> 
                    <FormTableAlternatingItemStyle Wrap="False"></FormTableAlternatingItemStyle> 
                    <FormStyle Width="100%" BackColor="#EEF2EA"></FormStyle> 
                    <EditColumn UpdateText="Update record" UniqueName="EditCommandColumn1" CancelText="Cancel edit">  
                    </EditColumn> 
                    <FormTableButtonRowStyle HorizontalAlign="Right" CssClass="EditFormButtonRow"></FormTableButtonRowStyle> 
                </EditFormSettings> 
                <ExpandCollapseColumn Visible="False">  
                    <HeaderStyle Width="19px"></HeaderStyle> 
                </ExpandCollapseColumn> 
                <RowIndicatorColumn Visible="False">  
                    <HeaderStyle Width="20px" /> 
                </RowIndicatorColumn> 
            </MasterTableView> 
        </radG:RadGrid> 
 
         
    </div> 
    </form> 
</body>
</html>