CREATE DATABASE jidfit
USE [jidfit]
GO
/****** Object:  Table [dbo].[assign_plate]    Script Date: 11/26/2023 3:59:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[assign_plate](
	[plate_name] [varchar](50) NOT NULL,
	[user_email] [varchar](50) NOT NULL,
	[meal_type] [int] NOT NULL,
	[day] [int] NOT NULL,
	[serving_amount] [int] NULL,
 CONSTRAINT [PK_assign_plate] PRIMARY KEY CLUSTERED 
(
	[plate_name] ASC,
	[user_email] ASC,
	[meal_type] ASC,
	[day] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[assigned_exercise]    Script Date: 11/26/2023 3:59:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[assigned_exercise](
	[user_email] [varchar](50) NOT NULL,
	[exercise_name] [varchar](50) NOT NULL,
	[day] [int] NOT NULL,
	[set_count] [int] NULL,
	[per_set_count] [int] NULL,
 CONSTRAINT [PK_assigend_exercise] PRIMARY KEY CLUSTERED 
(
	[user_email] ASC,
	[exercise_name] ASC,
	[day] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ate_plate]    Script Date: 11/26/2023 3:59:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ate_plate](
	[user_email] [varchar](50) NOT NULL,
	[plate_name] [varchar](50) NOT NULL,
	[time_ate] [datetime] NOT NULL,
	[serving] [int] NULL,
	[serving_unit] [int] NULL,
 CONSTRAINT [PK_ate_plate] PRIMARY KEY CLUSTERED 
(
	[user_email] ASC,
	[plate_name] ASC,
	[time_ate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[coach_or_nut]    Script Date: 11/26/2023 3:59:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[coach_or_nut](
	[coach_email] [varchar](50) NOT NULL,
	[coach_name] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[role] [bit] NULL,
 CONSTRAINT [PK_coach_or_nut] PRIMARY KEY CLUSTERED 
(
	[coach_email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[did_exercise]    Script Date: 11/26/2023 3:59:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[did_exercise](
	[user_email] [varchar](50) NOT NULL,
	[exercise_name] [varchar](50) NOT NULL,
	[time_did] [datetime] NOT NULL,
	[did_count] [int] NOT NULL,
 CONSTRAINT [PK_did_exercise] PRIMARY KEY CLUSTERED 
(
	[user_email] ASC,
	[exercise_name] ASC,
	[time_did] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[exercise]    Script Date: 11/26/2023 3:59:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[exercise](
	[exercise_name] [varchar](50) NOT NULL,
	[target_muscle] [varchar](50) NULL,
	[illust_link] [varchar](50) NULL,
 CONSTRAINT [PK_exercise] PRIMARY KEY CLUSTERED 
(
	[exercise_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[has_problems]    Script Date: 11/26/2023 3:59:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[has_problems](
	[problem_name] [varchar](50) NOT NULL,
	[user_email] [varchar](50) NOT NULL,
 CONSTRAINT [PK_has_problems] PRIMARY KEY CLUSTERED 
(
	[problem_name] ASC,
	[user_email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[notification]    Script Date: 11/26/2023 3:59:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[notification](
	[user_email] [varchar](50) NOT NULL,
	[time] [time](7) NOT NULL,
	[title] [varchar](50) NULL,
	[body] [text] NULL,
	[unread] [bit] NULL,
 CONSTRAINT [PK_notification] PRIMARY KEY CLUSTERED 
(
	[user_email] ASC,
	[time] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nut_achievement]    Script Date: 11/26/2023 3:59:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nut_achievement](
	[date_achieved] [date] NOT NULL,
	[coach_email] [varchar](50) NOT NULL,
	[url] [varchar](50) NULL,
	[type] [varchar](50) NULL,
	[describtion] [text] NULL,
 CONSTRAINT [PK_nut_achievement] PRIMARY KEY CLUSTERED 
(
	[date_achieved] ASC,
	[coach_email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[payment]    Script Date: 11/26/2023 3:59:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[payment](
	[user_email] [varchar](50) NOT NULL,
	[coach_email] [varchar](50) NOT NULL,
	[day] [date] NOT NULL,
 CONSTRAINT [PK_payment] PRIMARY KEY CLUSTERED 
(
	[user_email] ASC,
	[coach_email] ASC,
	[day] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[plates]    Script Date: 11/26/2023 3:59:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[plates](
	[plate_name] [varchar](50) NOT NULL,
	[amount] [int] NULL,
	[unit] [varchar](50) NULL,
	[protien] [decimal](3, 2) NULL,
	[fat] [decimal](3, 2) NULL,
	[carbs] [decimal](3, 2) NULL,
	[calories] [decimal](3, 2) NULL,
 CONSTRAINT [PK_plates] PRIMARY KEY CLUSTERED 
(
	[plate_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[problems]    Script Date: 11/26/2023 3:59:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[problems](
	[name] [varchar](50) NOT NULL,
	[type] [int] NULL,
 CONSTRAINT [PK_problems] PRIMARY KEY CLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reports]    Script Date: 11/26/2023 3:59:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reports](
	[title] [varchar](50) NOT NULL,
	[date_created] [datetime] NOT NULL,
	[type] [int] NULL,
	[report_content] [text] NULL,
	[action] [int] NULL,
	[user_email] [varchar](50) NULL,
	[coach_email] [varchar](50) NULL,
 CONSTRAINT [PK_reports] PRIMARY KEY CLUSTERED 
(
	[title] ASC,
	[date_created] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 11/26/2023 3:59:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[user_email] [varchar](50) NOT NULL,
	[weight] [decimal](3, 2) NULL,
	[birthdate] [date] NULL,
	[user_name] [varchar](50) NULL,
	[gender] [bit] NULL,
	[target] [int] NULL,
	[password] [varchar](50) NULL,
	[height] [decimal](3, 2) NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[user_email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[assign_plate]  WITH CHECK ADD  CONSTRAINT [FK_assign_plate_plates] FOREIGN KEY([plate_name])
REFERENCES [dbo].[plates] ([plate_name])
GO
ALTER TABLE [dbo].[assign_plate] CHECK CONSTRAINT [FK_assign_plate_plates]
GO
ALTER TABLE [dbo].[assign_plate]  WITH CHECK ADD  CONSTRAINT [FK_assign_plate_users] FOREIGN KEY([user_email])
REFERENCES [dbo].[users] ([user_email])
GO
ALTER TABLE [dbo].[assign_plate] CHECK CONSTRAINT [FK_assign_plate_users]
GO
ALTER TABLE [dbo].[assigned_exercise]  WITH CHECK ADD  CONSTRAINT [FK_assigend_exercise_exercise] FOREIGN KEY([exercise_name])
REFERENCES [dbo].[exercise] ([exercise_name])
GO
ALTER TABLE [dbo].[assigned_exercise] CHECK CONSTRAINT [FK_assigend_exercise_exercise]
GO
ALTER TABLE [dbo].[assigned_exercise]  WITH CHECK ADD  CONSTRAINT [FK_assigend_exercise_users] FOREIGN KEY([user_email])
REFERENCES [dbo].[users] ([user_email])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[assigned_exercise] CHECK CONSTRAINT [FK_assigend_exercise_users]
GO
ALTER TABLE [dbo].[ate_plate]  WITH CHECK ADD  CONSTRAINT [FK_ate_plate_plates] FOREIGN KEY([plate_name])
REFERENCES [dbo].[plates] ([plate_name])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ate_plate] CHECK CONSTRAINT [FK_ate_plate_plates]
GO
ALTER TABLE [dbo].[ate_plate]  WITH CHECK ADD  CONSTRAINT [FK_ate_plate_users] FOREIGN KEY([user_email])
REFERENCES [dbo].[users] ([user_email])
GO
ALTER TABLE [dbo].[ate_plate] CHECK CONSTRAINT [FK_ate_plate_users]
GO
ALTER TABLE [dbo].[did_exercise]  WITH CHECK ADD  CONSTRAINT [FK_did_exercise_exercise] FOREIGN KEY([exercise_name])
REFERENCES [dbo].[exercise] ([exercise_name])
GO
ALTER TABLE [dbo].[did_exercise] CHECK CONSTRAINT [FK_did_exercise_exercise]
GO
ALTER TABLE [dbo].[did_exercise]  WITH CHECK ADD  CONSTRAINT [FK_did_exercise_users] FOREIGN KEY([user_email])
REFERENCES [dbo].[users] ([user_email])
GO
ALTER TABLE [dbo].[did_exercise] CHECK CONSTRAINT [FK_did_exercise_users]
GO
ALTER TABLE [dbo].[has_problems]  WITH CHECK ADD  CONSTRAINT [FK_has_problems_problems] FOREIGN KEY([problem_name])
REFERENCES [dbo].[problems] ([name])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[has_problems] CHECK CONSTRAINT [FK_has_problems_problems]
GO
ALTER TABLE [dbo].[has_problems]  WITH CHECK ADD  CONSTRAINT [FK_has_problems_users] FOREIGN KEY([user_email])
REFERENCES [dbo].[users] ([user_email])
GO
ALTER TABLE [dbo].[has_problems] CHECK CONSTRAINT [FK_has_problems_users]
GO
ALTER TABLE [dbo].[notification]  WITH CHECK ADD  CONSTRAINT [FK_notification_users] FOREIGN KEY([user_email])
REFERENCES [dbo].[users] ([user_email])
GO
ALTER TABLE [dbo].[notification] CHECK CONSTRAINT [FK_notification_users]
GO
ALTER TABLE [dbo].[nut_achievement]  WITH CHECK ADD  CONSTRAINT [FK_nut_achievement_coach_or_nut] FOREIGN KEY([coach_email])
REFERENCES [dbo].[coach_or_nut] ([coach_email])
GO
ALTER TABLE [dbo].[nut_achievement] CHECK CONSTRAINT [FK_nut_achievement_coach_or_nut]
GO
ALTER TABLE [dbo].[payment]  WITH CHECK ADD  CONSTRAINT [FK_payment_users] FOREIGN KEY([user_email])
REFERENCES [dbo].[users] ([user_email])
GO
ALTER TABLE [dbo].[payment] CHECK CONSTRAINT [FK_payment_users]
GO
ALTER TABLE [dbo].[payment]  WITH CHECK ADD  CONSTRAINT [FK_payment_users1] FOREIGN KEY([user_email])
REFERENCES [dbo].[users] ([user_email])
GO
ALTER TABLE [dbo].[payment] CHECK CONSTRAINT [FK_payment_users1]
GO
ALTER TABLE [dbo].[reports]  WITH CHECK ADD  CONSTRAINT [FK_reports_coach_or_nut] FOREIGN KEY([coach_email])
REFERENCES [dbo].[coach_or_nut] ([coach_email])
GO
ALTER TABLE [dbo].[reports] CHECK CONSTRAINT [FK_reports_coach_or_nut]
GO
ALTER TABLE [dbo].[reports]  WITH CHECK ADD  CONSTRAINT [FK_reports_users] FOREIGN KEY([coach_email])
REFERENCES [dbo].[users] ([user_email])
GO
ALTER TABLE [dbo].[reports] CHECK CONSTRAINT [FK_reports_users]
GO
