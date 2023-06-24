CREATE USER 'Viewer'@'%' IDENTIFIED BY 'viewerpassword';
CREATE USER 'Buyer'@'%' IDENTIFIED BY 'buyerpassword';
CREATE USER 'Repairman'@'%' IDENTIFIED BY 'repairmanpassword';

GRANT SELECT ON pnppk.* TO 'Viewer'@'%';

GRANT SELECT, INSERT, UPDATE ON pnppk.hardware TO 'Buyer'@'%';
GRANT SELECT, INSERT, UPDATE ON pnppk.Hardware_Value TO 'Buyer'@'%';
GRANT SELECT, INSERT, UPDATE, DELETE ON pnppk.Disk TO 'Buyer'@'%';

GRANT SELECT, INSERT, UPDATE ON pnppk.Hardware_Value TO 'Repairman'@'%';
GRANT SELECT, INSERT, UPDATE ON pnppk.hardware TO 'Repairman'@'%';
GRANT SELECT, INSERT, UPDATE ON pnppk.Hardware_Type TO 'Repairman'@'%';
GRANT SELECT, INSERT, UPDATE ON pnppk.Access TO 'Repairman'@'%';
GRANT SELECT, INSERT, UPDATE ON pnppk.Place TO 'Repairman'@'%';
GRANT SELECT, INSERT, UPDATE ON pnppk.Department_Dict TO 'Repairman'@'%';
GRANT SELECT, INSERT, UPDATE ON pnppk.Repair TO 'Repairman'@'%';
GRANT SELECT, INSERT, UPDATE ON pnppk.Hardware_Property TO 'Repairman'@'%';
GRANT SELECT ON pnppk.History TO 'Repairman'@'%';
GRANT SELECT, INSERT, UPDATE, DELETE ON pnppk.Disk TO 'Repairman'@'%';

