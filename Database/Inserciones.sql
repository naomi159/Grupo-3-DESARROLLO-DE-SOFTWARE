USE BDTutoria
GO

/*ELIMINAR ELEMENTOS DE TODAS LAS TABLAS*/
--Desactivar limitaciones de todas las tablas
EXEC sys.sp_msforeachtable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL' 

--Eliminar elementos de todas las tablas
EXEC sys.sp_msforeachtable 'DELETE FROM ?'

--Activar limitaciones de todas las tablas
EXEC sys.sp_MSForEachTable 'ALTER TABLE ? CHECK CONSTRAINT ALL'
go


--INSERCION ESTUDIANTES
insert into Estudiante values('182456','Norma','Jimenez','Padilla','IN','Normal')
insert into Estudiante values('145678','Marcelo','Lopez', 'Ortega','ME','En riesgo')
insert into Estudiante values('134521','Carlos' ,'Quispe',' Puma','IN','En riesgo')
insert into Estudiante values('176542','Sara'   ,'Ezquvel', 'Hernanadez','CO','Normal')
insert into Estudiante values('189023','Rosalia','Sanchez','Flores','IQ','Normal')
insert into Estudiante values('196541','Mabel'  ,'Huaman','Huarca','IPQ','En riesgo')
insert into Estudiante values('187691','Juan'   ,'Mamani',' Quispe','ME','En riesgo')
insert into Estudiante values('184567','Pedro','Perez','Sarmiento','ME','Normal')
insert into Estudiante values('174512','Vanesa','Gutierrez','Choque','IN','En riesgo')
insert into Estudiante values('167734','Laura','Vilchez','Vilchez','IN','Normal')
insert into Estudiante values('202879','Efrain','Uribe','Quiroz','IN','En riesgo')
insert into Estudiante values('202478','Demian','Olimpo','Gallardo','IN','En riesgo')
insert into Estudiante values('183456','Angie','Garcia','Correa','IN','Normal')
insert into Estudiante values('161657','Armando','Casas','Delgado','ME','Normal')
insert into Estudiante values('144545','Rosmira','Benavidez','Ordoñez','ME','En riesgo')
insert into Estudiante values('155577','Marshal','Escalante','Luna','IN','Normal')
insert into Estudiante values('188976','Joel','Salcedo','Pinarez','IQ','En riesgo')

--INSERCION DOCENTES
insert into Docente values('10000','Abdon','Rivas','Puga','Nombrado','Principal','Tiempo Completo','IN')
insert into Docente values('10001','Ana Rocio','Cardenas','Maita','Contratado','Tipo B','B1','IN')
insert into Docente values('10002','Dennis Ivan','Candia','Oviedo','Nombrado','Asociado','Tiempo Completo','IN')
insert into Docente values('10003','Doris Sabina','Aguirre','Carbajal','Contratado','Tipo B','B3','IN')
insert into Docente values('10004','Edwin','Carrasco','Poblete','Nombrado','Principal','Tiempo Completo','IN')
insert into Docente values('10005','Efrina Gladys','Cutipa','Arapa','Contratado','Tipo B','B1','IN')
insert into Docente values('10006','Emilio','Palomino','Olivera','Nombrado','Principal','Tiempo Completo','IN')
insert into Docente values('10007','Enrique','Gamarra','Saldivar','Nombrado','Principal','Tiempo Completo','IN')
insert into Docente values('10008','Esther Cristina','Pacheco','Vasquez','Nombrado','Auxiliar','Tiempo Completo','IN')
insert into Docente values('10009','Guzman','Ticona','Pari','Nombrado','Asociado','Dedicacion Exclusiva','IN')
insert into Docente values('10010','Harley','Vera','Olivera','Contratado','Tipo B','B1','IN')
insert into Docente values('10011','Henry Samuel','Dueñas','De la Cruz','Contratado','Tipo B','B2','IN')
insert into Docente values('10012','Hernan','Castañeda','Chirinos','Contratado','Tipo B','B2','IN')
insert into Docente values('10013','Hernan','Nina','Hanco','Contratado','Tipo A','A1','IN')
insert into Docente values('10014','Ivan Cesar','Medrano','Valencia','Nombrado','Asociado','Tiempo Completo','IN')
insert into Docente values('10015','Javier Arturo','Rozas','Huacho','Nombrado','Principal','Dedicacion Exclusiva','IN')
insert into Docente values('10016','Javier David','Chavez','Centeno','Nombrado','Auxiliar','Tiempo Completo','IN')
insert into Docente values('10017','Jose Mauro','Pillco','Quispe','Nombrado','Auxiliar','Tiempo Completo','IN')
insert into Docente values('10018','Julio Cesar','Carbajal','Luna','Nombrado','Principal','Tiempo Completo','IN')
insert into Docente values('10019','Karelia','Medina','Miranda','Nombrado','Asociado','Tiempo Parcial','IN')
insert into Docente values('10020','Lauro','Enciso','Rodas','Nombrado','Principal','Dedicacion Exclusiva','IN')
insert into Docente values('10021','Lino Aquiles','Baca','Cardenas','Nombrado','Auxiliar','Tiempo Completo','IN')
insert into Docente values('10022','Lino Prisciliano','Flores','Pacheco','Nombrado','Principal','Tiempo Completo','IN')
insert into Docente values('10023','Luis Alvaro','Monzon','Condori','Contratado','Tipo B','B3','IN')
insert into Docente values('10024','Luis Beltran','Palma','Ttito','Nombrado','Asociado','Tiempo Completo','IN')
insert into Docente values('10025','Manuel Aurelio','Peñaloza','Figueroa','Nombrado','Asociado','Tiempo Parcial','IN')
insert into Docente values('10026','Maritza Katherine','Irpanocca','Cusimayta','Contratado','Tipo B','B1','IN')
insert into Docente values('10027','Nila Zonia','Acurio','Usca','Nombrado','Principal','Dedicacion Exclusiva','IN')
insert into Docente values('10028','Robert Wilbert','Alzamora','Paredes','Nombrado','Asociado','Tiempo Completo','IN')
insert into Docente values('10029','Rony','Villafuerte','Serna','Nombrado','Asociado','Tiempo Completo','IN')
insert into Docente values('10030','Vanesa Maribel','Choque','Soto','Contratado','Tipo B','B2','IN')
insert into Docente values('10031','Waldo Elio','Ibarra','Zambrano','Nombrado','Auxiliar','Tiempo Completo','IN')
insert into Docente values('10032','Waldo','Villa','Rodriguez','Contratado','Tipo B','B1','IN')
insert into Docente values('10033','Willian','Zamalloa','Paro','Contratado','Tipo B','B1','IN')
insert into Docente values('10034','Yeshica Isela','Ormeño','Ayala','Nombrado','Asociado','Dedicacion Exclusiva','IN')

--INSERCION USUARIO
--pass: 1234
insert into Usuario values('10000','81dc9bdb52d04dc20036dbd8313ed055');

--INSERCION FICHA TUTORIA
-- Clave: 1234
insert into FichaTutoria values('10003','182456','2020-I','2021-05-24','QLzxILKuUdOukbNaCao+RPRSnngLCgpIfv9Rl6gCItYdvMwFHlHEen/Pmi6OVturLxWlLE9QxFMDSp/9sw5UFrftqMLmMY7lm1DETZ71CG4DYsoLnxgo5GzVm3D7TrujrTuGfoloxnfxbFBjfZdaWT/0dBqkv0nZaS8ez8U9354=')
insert into FichaTutoria values('10003','145678','2020-I','2021-05-12','QLzxILKuUdOukbNaCao+RPRSnngLCgpIfv9Rl6gCItYdvMwFHlHEen/Pmi6OVturLxWlLE9QxFMDSp/9sw5UFrftqMLmMY7lm1DETZ71CG4DYsoLnxgo5GzVm3D7TrujrTuGfoloxnfxbFBjfZdaWT/0dBqkv0nZaS8ez8U9354=')
insert into FichaTutoria values('10004','134521','2020-I','2021-05-18','Msu8n4r5BIrq9TsCzijQ3CeDeZpgK728Sb88bf9SL8P9YhnsoQVqGUBgPEvhce0AQOvKejfZI4hxXbo216EAAubUYI8xLxsNggGJC18w6YWWUxwZSdgHZ9AtTdg7+GxRJqxbflhLARu8gFdgeeEAi74oL4dxeEuO8TYuvSCKGkY=')
insert into FichaTutoria values('10005','176542','2020-I','2021-06-14','Msu8n4r5BIrq9TsCzijQ3CeDeZpgK728Sb88bf9SL8P9YhnsoQVqGUBgPEvhce0AQOvKejfZI4hxXbo216EAAubUYI8xLxsNggGJC18w6YWWUxwZSdgHZ9AtTdg7+GxRJqxbflhLARu8gFdgeeEAi74oL4dxeEuO8TYuvSCKGkY=')
insert into FichaTutoria values('10006','189023','2020-I','2021-05-04','Msu8n4r5BIrq9TsCzijQ3CeDeZpgK728Sb88bf9SL8P9YhnsoQVqGUBgPEvhce0AQOvKejfZI4hxXbo216EAAubUYI8xLxsNggGJC18w6YWWUxwZSdgHZ9AtTdg7+GxRJqxbflhLARu8gFdgeeEAi74oL4dxeEuO8TYuvSCKGkY=')
insert into FichaTutoria values('10007','196541','2020-I','2021-06-15','dPTA4UBYvUo+kbL+LRETxvZiEmK5sDswleTLdSLTbicSi7sJn3U8y4YUTbN3bqpBGycvLyJV7vEpdkK3G/ni4WAuQrA0jaoUKHSMcJJd4+tBkrZxzS2EBG9wFV2tpD6UKLlSZ26PJWFAzaNSZSnJ1MOc9cZXMkk/E0YR/CTpmGM=')
insert into FichaTutoria values('10008','187691','2020-I','2021-06-30','dPTA4UBYvUo+kbL+LRETxvZiEmK5sDswleTLdSLTbicSi7sJn3U8y4YUTbN3bqpBGycvLyJV7vEpdkK3G/ni4WAuQrA0jaoUKHSMcJJd4+tBkrZxzS2EBG9wFV2tpD6UKLlSZ26PJWFAzaNSZSnJ1MOc9cZXMkk/E0YR/CTpmGM=')
insert into FichaTutoria values('10009','184567','2020-II','2021-06-24','MGM8uMAPYFCK0OJ3yEPXX+Qpcqc3wiCPV5lDHLJzxjJLtUe++8Q7ZjWJQQWfM82zZDSsVNmAjPvbaCAqM3+Jtc0f64c/XMJKLa0BhinY0t0paqwn6uBen+AwJMv3e4tx44mo4B4Sd4699TqM2XUrbNywbGdC/4/38PGUHMNG2KU=')
insert into FichaTutoria values('10009','174512','2020-II','2021-06-24','MGM8uMAPYFCK0OJ3yEPXX+Qpcqc3wiCPV5lDHLJzxjJLtUe++8Q7ZjWJQQWfM82zZDSsVNmAjPvbaCAqM3+Jtc0f64c/XMJKLa0BhinY0t0paqwn6uBen+AwJMv3e4tx44mo4B4Sd4699TqM2XUrbNywbGdC/4/38PGUHMNG2KU=')
insert into FichaTutoria values('10006','167734','2020-II','2021-06-02','MGM8uMAPYFCK0OJ3yEPXX+Qpcqc3wiCPV5lDHLJzxjJLtUe++8Q7ZjWJQQWfM82zZDSsVNmAjPvbaCAqM3+Jtc0f64c/XMJKLa0BhinY0t0paqwn6uBen+AwJMv3e4tx44mo4B4Sd4699TqM2XUrbNywbGdC/4/38PGUHMNG2KU=')
insert into FichaTutoria values('10013','202879','2020-II','2021-05-05','SJ5Fncp+ML7txQw8H1QFpOpW8jZ4H0KGsgaHIehIsGb/HUr0GjD9KLB2Z1zduhu5lwJ9+DWZIBcmfI9zPgUmzEgatWK7r3Gn+d9FHuWcOU7qz+1b9IBUJ99BuOcJN314tDuQMJ/9F36c7ivZ9CCr94ffZiqQrQq9v4LJNueyGig=')
insert into FichaTutoria values('10014','202478','2020-II','2021-05-24','SJ5Fncp+ML7txQw8H1QFpOpW8jZ4H0KGsgaHIehIsGb/HUr0GjD9KLB2Z1zduhu5lwJ9+DWZIBcmfI9zPgUmzEgatWK7r3Gn+d9FHuWcOU7qz+1b9IBUJ99BuOcJN314tDuQMJ/9F36c7ivZ9CCr94ffZiqQrQq9v4LJNueyGig=')
insert into FichaTutoria values('10015','183456','2020-II','2021-05-20','SJ5Fncp+ML7txQw8H1QFpOpW8jZ4H0KGsgaHIehIsGb/HUr0GjD9KLB2Z1zduhu5lwJ9+DWZIBcmfI9zPgUmzEgatWK7r3Gn+d9FHuWcOU7qz+1b9IBUJ99BuOcJN314tDuQMJ/9F36c7ivZ9CCr94ffZiqQrQq9v4LJNueyGig=')
insert into FichaTutoria values('10016','161657','2020-II','2021-06-24','DJT/iPGY39hLsF0CbiTCESfF8js5AEyJ5WfomUakelE8hMfndGnChSjVWcePlouJFwvZk4FIqdVDuti38zaT5L0f/Ox93VsLiKUE/3pS1wkpCKBt2DLXXBDj+rHFO9mTCuo3WB8m0riYwB3YpSqAycPuSqHa6UHinvnXT+Cq36A=')
insert into FichaTutoria values('10017','144545','2020-II','2021-06-24','DJT/iPGY39hLsF0CbiTCESfF8js5AEyJ5WfomUakelE8hMfndGnChSjVWcePlouJFwvZk4FIqdVDuti38zaT5L0f/Ox93VsLiKUE/3pS1wkpCKBt2DLXXBDj+rHFO9mTCuo3WB8m0riYwB3YpSqAycPuSqHa6UHinvnXT+Cq36A=')