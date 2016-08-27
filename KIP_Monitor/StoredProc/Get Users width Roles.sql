SELECT        dbo.Users.id_User, dbo.Users.UserName, dbo.Users.Password, dbo.Role.Role
FROM            dbo.Role INNER JOIN
                         dbo.Users ON dbo.Role.id_role = dbo.Users.id_role