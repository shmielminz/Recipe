exec StaffGet

exec StaffGet @Username = ''

exec StaffGet @Username = null

exec StaffGet @Username = 's'

exec StaffGet @All = 1

declare @Id int
select top 1 @Id = s.StaffId from Staff s
exec StaffGet @StaffId = @Id