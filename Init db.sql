CREATE DATABASE [Pytania];

use [Pytania];

CREATE TABLE [dbo].[Pytanie](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[kategoria] [varchar](200) NOT NULL, 
	[pytanie] [varchar](2000) NOT NULL,
	[odpowiedzA] [varchar](200) NOT NULL,
	[odpowiedzB] [varchar](200) NOT NULL,
	[odpowiedzC] [varchar](200) NOT NULL,
	[odpowiedzD] [varchar](200) NOT NULL,
	[czyWolne] [bit] NOT NULL,
 CONSTRAINT [PK_Pytanie] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Pytanie] ADD  CONSTRAINT [DF_Pytanie_czyWolne]  DEFAULT ((0)) FOR [czyWolne]
GO


