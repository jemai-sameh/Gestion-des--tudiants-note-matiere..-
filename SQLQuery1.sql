select * from enseignant where nom like '%f%'  ;
select id_matiere,nom_matiere,credit,Coefficient,DS,CONCAT(prenom,'  ',prenom) AS enseignant from matiere,enseignant where enseignant.id_enseignant=matiere.id_enseignant;
select  * from note;
select * from matiere;