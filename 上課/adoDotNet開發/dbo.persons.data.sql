use mydb
go

SET IDENTITY_INSERT [dbo].[persons] ON
INSERT INTO [dbo].[persons] ([Id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [會員點數]) VALUES (1, N'陳大貓                                               ', N'0912345678', N'高雄市前金區中正路', N'mm@hh.com.tw                                      ', N'1985-05-05', 0, 1000)
INSERT INTO [dbo].[persons] ([Id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [會員點數]) VALUES (2, N'黃小貓                                               ', N'0966333222', N'高雄市三民區民族路', N'pp@nn.com                                         ', N'1988-06-03', 1, 500)
INSERT INTO [dbo].[persons] ([Id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [會員點數]) VALUES (3, N'張大書                                               ', N'0977555111', N'高雄市鼓山區美術路', N'zz@ddd.com.tw                                     ', N'1987-11-09', 1, 2000)
INSERT INTO [dbo].[persons] ([Id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [會員點數]) VALUES (4, N'林阿霈                                               ', N'0999111666', N'台南市東區中華路', N'rr@ttt.com                                        ', N'1979-01-05', 0, 1500)
INSERT INTO [dbo].[persons] ([Id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [會員點數]) VALUES (5, N'王小明                                               ', N'0955111888', N'台中市西屯區', N'www@vv.com.tw                                     ', N'1992-08-20', 1, 300)
INSERT INTO [dbo].[persons] ([Id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [會員點數]) VALUES (6, N'許大衛                                               ', N'0947111345', N'台南市西區中正路', N'wwq@cfo.com.tw                                    ', N'1977-04-05', 0, 1550)
SET IDENTITY_INSERT [dbo].[persons] OFF

select*from dbo.persons