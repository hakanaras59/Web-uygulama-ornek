<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Personel.aspx.cs" Inherits="Personel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <section id="two" class="wrapper style2">
				<div class="inner">
					<div class="box">
						<div class="content">
							<header class="align-center">
								<p>gÖNÜLLÜ ÇALIŞANLARIZ<br />
                                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                                        <Columns>
                                            <asp:BoundField DataField="Uye_No" HeaderText="Uye_No" SortExpression="Uye_No" />
                                            <asp:BoundField DataField="Ad_Soyad" HeaderText="Ad_Soyad" SortExpression="Ad_Soyad" />
                                            <asp:BoundField DataField="Katilim_Yili" HeaderText="Katilim_Yili" SortExpression="Katilim_Yili" />
                                            <asp:BoundField DataField="Yardimlari" HeaderText="Yardimlari" SortExpression="Yardimlari" />
                                            <asp:BoundField DataField="Meslek" HeaderText="Meslek" SortExpression="Meslek" />
                                        </Columns>
                                    </asp:GridView>
                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:emreConnectionString %>" SelectCommand="SELECT [Uye_No], [Ad_Soyad], [Katilim_Yili], [Yardimlari], [Meslek] FROM [personel]"></asp:SqlDataSource>
                                </p>
								
							</header>
							<p>&nbsp;</p>

							
						</div>
					</div>
				</div>
			</section>
</asp:Content>

