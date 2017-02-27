﻿EXECUTE sp_rename @objname = N'dbo.Usuarios.STR_NOME', @newname = N'Nome', @objtype = N'COLUMN'
ALTER TABLE [dbo].[Usuarios] ALTER COLUMN [Nome] [varchar](150) NOT NULL
DECLARE @var0 nvarchar(128)
SELECT @var0 = name
FROM sys.default_constraints
WHERE parent_object_id = object_id(N'dbo.Usuarios')
AND col_name(parent_object_id, parent_column_id) = 'Teste';
IF @var0 IS NOT NULL
    EXECUTE('ALTER TABLE [dbo].[Usuarios] DROP CONSTRAINT [' + @var0 + ']')
ALTER TABLE [dbo].[Usuarios] DROP COLUMN [Teste]
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'201702272230416_AutomaticMigration', N'app.Data.Migrations.Configuration',  0x1F8B0800000000000400D55ACD6EE33610BE17E83B083A1659CBCEA2C0D6B0779138C9C2E82659C4CEA2B7052D8D1DA214A915A9C0C6A24FD6431FA9AFD0D11F2551962DD9F9D9229788E47C331CCE0C395FF2EFDFFF8C3EAC7D663D4228A9E0637BD0EBDB1670577894AFC676A4966FDED91FDEFFFCD3E8D2F3D7D6977CDDDB781D4A7239B61F940A868E23DD07F089ECF9D40D85144BD57385EF104F38A7FDFE6FCE60E00042D8886559A3BB882BEA43F2819F13C15D085444D8B5F080C96C1C676609AA75437C900171616C9320E85D10457A28A460AD6CEB8C518276CC802D6D8B702E145168E5F05EC24C8582AF66010E1036DF0480EB968449C8AC1F16CBDB6EA47F1A6FC42904732837924AF81D01076F33CF38A6F841FEB5B5E7D07797E863B589779DF86F6C5F720F4270856D99CA861316C60B13F74EEEEE2F7A17C2A79C8A5E722042F672D913CB5871A2A3028327FE39B12611535108630E910A093BB13E470B46DDDF6133177F021FF388B1B2A5682BCE550670E873280208D5E60E9686FD53CFB69CAABC630268F12DB2E94E3F46147FBF415BC882818E0B6727CC04825C1E630B93C4B6AEC9FA13F0957A18DBEF6CEB8AAEC1CBBF551821E23DA79850907F76D4F849AC423CE528143B140F7EED1BAA33ECE374DF443E147AA75CBD3DED8C714E68B8D3F6E731FD4CD147ADF55C0806847706B95CBB0CA3E4689C7B199190768EBD1BF24857497E6EC7B3AD3B60C9BC7CA0415A0175A27ED58BAE42E1DF09564A827CEEEB0CE3CA45C573D1B0604EC215A8AA6523A7A82C3BEB8DB6A07BB9C9445FB3DA940EAD6BB139F0BCCDEC133EBC7CCECFC42204BE4775BF9DEA3DB5F4F3D52E1D836728A6973EA1ECE57D1ABF576E8874F1C9C395AE26380A73EA7787FB081C765F074F723EAF5B421B8B5F5EA3E4F1E52FAF6E8DE52FAF8F6DCADF9994C2A5893D86A5DA96EA0E71DADA5797D3132E6F0C0F1A0B1E0DB0C4A11163FB979AE776E0EA0D17B8DA4F55D8410D162B2382F1F8258D4F6F89B59672552FA394BB34206C8F05865CB7021C9F815664CE5C4000A894AB3DBE3DDA02ADC8B81CF6F969E49422A57E7FC66D0D4A409867215E8079A753BB47B1C5C9AE5299E5B4190A31E40C543D778A20AE05582D9EAA209957B661E86032204A3BAE1B53A46A6959533A9BC7D02289B4FD95FDD70EB445DA94900A27988F83EA5EB7140E7DC2459BEBA47D6EDE0F3B0D0DF1E81A9F4358EC4B0D723662CDD2EE78F266D6BD71F4530CC7955BFA476DADD6A444485660CCA26AB4F48A8652C5B7DD82C4257DE2F9B565A5786E08B35C9119B2F503CBA32F97887F4FA54C96A088EE7ADE67D257B8ABF87E4E36085B82A62E9A101484917047B339112CF2F9BE0676175AD27396619281F6F2E50EB20C531E6F8F96F78465A47CAC3D4ADE159651F2B1F628D90BA50C920DB5C7281E289593D2A3ED914AB745196AC72512A7BA117DB56BA616E546B931D3A65552E9EA75544E35D4E41629D528F994BE6D8CE0A4B9A9C46F32D21EA1D42395614AC31DB23BEE822AD91D0F7488DFB4A5A9046F3AD41EC3EC4FCA60E65C7BD4BC4D29A3E5633F7A8E3F6B5ED61E02E612AD5D3F088C8B7F945DC2FBE9F2DAAD9C2EB12D74D123F5E21B79B6910AFC34B567DFD88451DC6FB1E09A70BA04A95236C53EED0F4E0DCEFDC7E1BF1D293DD692047F75023AE2F45B04346E21E89242780C19FD4842F78184261B7D34D7BC0D3721498E6292691C5F47F1C8DBEC3AC0AC0AC5B1A0DDAD32E98D43306A6C613D306A8DDF14A3693DB6BF2710436BFAC7578D7262DD86186A43AB6FFDB5C796CE4CEE2BD3A847674C99527DAAD0AE11A65B81FB15E08EF4A8466C11072876624DE57DE2AAA135474D711C18CCEA31BCE953396E3B2BEA1105EA7856F4890EE1150AC433F08B9A603984F7ABF32207F292071188CD3DC6731386FF1B86B04EBCB42301777280E93311D371111F771AAC8DEC591345B88B21DCA6A091547B09FED0B0B9D2A7B6610BB7128DCF430FD65FFF1854A57FA9C19896745540C4FF60C3C1AD84935E33E54B9107B66151BEC4A869D7A00896697216E2354C5C85D32E4899FC15EA0B615172612CC09BF2DB480591C22D83BF609BB233E2ECD8A53FE140AB368F6E83E48F3D4FB1053493C637CD2D3F8F28F3B4DD575BEA7103449C76C99D939E2566B182D54623DD08DE1228739FAE1673F0038660F296CFC8231C62DBBD844FB022EE266FE29A41F61F44D5EDA30B4AB04BF0658651C8E327C6B0E7AFDFFF07C819EB2B59260000 , N'6.1.3-40302')

