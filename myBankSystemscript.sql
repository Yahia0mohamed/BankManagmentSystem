USE [myBankSystem]
GO
/****** Object:  Table [dbo].[account]    Script Date: 5/24/2023 6:11:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[account](
	[accID] [varchar](10) NOT NULL,
	[balance] [float] NULL,
	[accType] [varchar](30) NULL,
	[SSN] [varchar](10) NULL,
 CONSTRAINT [PK_accID] PRIMARY KEY CLUSTERED 
(
	[accID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bank]    Script Date: 5/24/2023 6:11:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bank](
	[bankName] [varchar](30) NULL,
	[bankAddress] [varchar](50) NULL,
	[bankID] [varchar](10) NOT NULL,
	[branchnum] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[bankID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[branch]    Script Date: 5/24/2023 6:11:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[branch](
	[branchID] [varchar](10) NOT NULL,
	[branchAddress] [varchar](50) NULL,
	[bankID] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[branchID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 5/24/2023 6:11:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[SSN] [varchar](10) NOT NULL,
	[name] [varchar](30) NULL,
	[phone] [varchar](11) NULL,
	[address] [varchar](50) NULL,
	[branchID] [varchar](10) NULL,
	[userName] [varchar](10) NOT NULL,
	[password] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SSN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employee]    Script Date: 5/24/2023 6:11:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee](
	[employeeID] [varchar](10) NOT NULL,
	[branchID] [varchar](10) NULL,
	[userName] [varchar](20) NULL,
	[password] [varchar](20) NULL,
	[name] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[employeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Loan]    Script Date: 5/24/2023 6:11:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loan](
	[loanID] [varchar](10) NOT NULL,
	[loanType] [varchar](30) NULL,
	[amount] [float] NULL,
	[SSN] [varchar](10) NULL,
	[branchID] [varchar](10) NULL,
	[employeeID] [varchar](10) NOT NULL,
 CONSTRAINT [PK_LoanID] PRIMARY KEY CLUSTERED 
(
	[loanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[loanWaitingList]    Script Date: 5/24/2023 6:11:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[loanWaitingList](
	[customerName] [varchar](30) NULL,
	[loanType] [varchar](30) NULL,
	[amount] [float] NULL,
	[SSN] [varchar](10) NOT NULL,
	[branchID] [varchar](10) NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [COM_PK_SSN_BRANCHID] PRIMARY KEY CLUSTERED 
(
	[SSN] ASC,
	[branchID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[account]  WITH CHECK ADD  CONSTRAINT [FK_SSN_customer] FOREIGN KEY([SSN])
REFERENCES [dbo].[Customer] ([SSN])
GO
ALTER TABLE [dbo].[account] CHECK CONSTRAINT [FK_SSN_customer]
GO
ALTER TABLE [dbo].[branch]  WITH CHECK ADD  CONSTRAINT [FK_bankID] FOREIGN KEY([bankID])
REFERENCES [dbo].[bank] ([bankID])
GO
ALTER TABLE [dbo].[branch] CHECK CONSTRAINT [FK_bankID]
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD  CONSTRAINT [FK_BranchID_customer] FOREIGN KEY([branchID])
REFERENCES [dbo].[branch] ([branchID])
GO
ALTER TABLE [dbo].[Customer] CHECK CONSTRAINT [FK_BranchID_customer]
GO
ALTER TABLE [dbo].[employee]  WITH CHECK ADD  CONSTRAINT [FK_BranchID] FOREIGN KEY([branchID])
REFERENCES [dbo].[branch] ([branchID])
GO
ALTER TABLE [dbo].[employee] CHECK CONSTRAINT [FK_BranchID]
GO
ALTER TABLE [dbo].[Loan]  WITH CHECK ADD FOREIGN KEY([SSN])
REFERENCES [dbo].[Customer] ([SSN])
GO
ALTER TABLE [dbo].[Loan]  WITH CHECK ADD  CONSTRAINT [FK_BranchID_loan] FOREIGN KEY([branchID])
REFERENCES [dbo].[branch] ([branchID])
GO
ALTER TABLE [dbo].[Loan] CHECK CONSTRAINT [FK_BranchID_loan]
GO
ALTER TABLE [dbo].[Loan]  WITH CHECK ADD  CONSTRAINT [FK_EMPID_EMPLOYEE] FOREIGN KEY([employeeID])
REFERENCES [dbo].[employee] ([employeeID])
GO
ALTER TABLE [dbo].[Loan] CHECK CONSTRAINT [FK_EMPID_EMPLOYEE]
GO
ALTER TABLE [dbo].[loanWaitingList]  WITH CHECK ADD FOREIGN KEY([branchID])
REFERENCES [dbo].[branch] ([branchID])
GO
ALTER TABLE [dbo].[loanWaitingList]  WITH CHECK ADD FOREIGN KEY([SSN])
REFERENCES [dbo].[Customer] ([SSN])
GO
