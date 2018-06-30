--transaction
begin transaction

insert into Foo values(89,'XYZ','MATUNGA',70)
insert into Foo values(9,'XYZ','MATUNGA',71)
SELECT * FROM Foo
rollback
end