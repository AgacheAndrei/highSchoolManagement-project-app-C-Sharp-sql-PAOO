# High school mnagement - project app
## Project for univeristy 
## The goal of the app
<p>
 The application developed addresses the issue of managing both scholarship and non-scholarship students within a high school.
</p>

## Analyze problems

<p>
A high school is a general education institution where graduates of primary schools are admitted, and where the knowledge required for further studies in higher education or various vocational fields is taught.
A student is considered a scholarship recipient if they meet certain conditions imposed by the state and the educational institution they are a part of. According to the current legislation, there can be several types of scholarship recipients:
Please note that all scholarships require a minimum overall grade that must be exceeded to enter the scholarship application process. These minimum grades vary widely depending on the type of scholarship and current legislation.
</p>
<pre>
- Merit Scholars: These students have an overall grade above a minimum set by the high school and the Inspectorate for Education in the city where the high school is located.
- Olympic Scholars: These are students who have achieved outstanding results at national or international levels in various olympiads.
- Social Scholarships are divided into different categories based on the challenges faced by a student. These categories include scholarships for students who are orphaned by one or both parents, students from rural areas, students facing difficult situations, and students with serious health issues or disabilities.
</pre>
<p>
Scholarships represent compensation that varies depending on the type of scholarship and the current legislation, and it is given to the student or their guardian during the validity period of the scholarship application.
There are scholarships that last for:
</p>
<pre>
- 6 months, such as academic scholarships like merit scholarships and Olympic scholarships.
- 12 months, such as social scholarships in the categories mentioned above.
</pre>
For example, a merit scholarship can reach up to 600 lei per month.
<p>
All types of scholarships require different types of documents to be submitted by students in a dossier, and after the evaluation process, the student finds out whether they will be on the list of scholarship recipients. For example, a merit scholarship requires a copy of the ID card, a copy of the student's transcript, and other documents that are already available at the high school, such as a copy of the birth certificate.
Each student receives a specific code for the documents they submit for a particular scholarship, which helps in the quick identification of the desired scholarship type. The secretariat can search for students much more quickly and easily based on this code.
For example, the code "CICNFM" is for a student applying for a merit scholarship.
</p>
<pre>
 The main entities involved in the student management system are:
- The Student: Identified by:
  - Registration Number
  - Last Name
  - First Name
  - Personal Identification Number (CNP)
  - Other details such as address, phone number, overall grade, etc.
- The Administrator: Identified by:
  - An identifier received from the high school (authentication code, email, etc.)
  - Password
  - Role - What they are responsible for
- The Secretary: Identified by:
  - An identifier received from the high school (authentication code, email, etc.)
  - Password
  - Role - What they are responsible for
- The Type of Scholarship: Identified by:
  - Affiliated code
  - Set of rules for obtaining
  - Name
  - Required documents
  - Value
  - Duration
</pre>

## Code solution
<pre>
An application with a graphical interface created in C# for managing scholarship students at a high school. 
It includes:
 ->filtering the students🗃️ using different topics like scholarship, average score
 ->graphs📊 with important data 
 ->Excel📇 imports and exports 
 ->reports📑 on varios topics
 ->command history🧾 
 ->roles 👯(like admin and secretary)
 ->user👤 login
 ->user👥 creation
 ->deletion➖ of students (delete)
 ->addition➕ of students (insert)
 ->search🔍 with parameters
 ->student update⬆️
 ->Sing-out button📤
</pre>

### Programing languages and technology used

<img align="left" width="30px" style="padding-right:10px" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" />   
<img align="left" width="30px" style="padding-right:10px" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/mysql/mysql-original-wordmark.svg" />  
<img align="left" width="30px" style="padding-right:10px" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/visualstudio/visualstudio-plain.svg" />  
 
<br> 

### Photos and how to use it

#### Login -> use one of this users
##### Admin user🙍: andrei@cuza.com / password🛂: admin
##### Secretary user🙍: ana@cuza.com / password🛂: sec
![elevi_paoo](https://github.com/AgacheAndrei/highSchoolManagement-project-app-C-Sharp-sql-PAOO/assets/36128809/5c53926e-46f2-4b23-a7ea-9e026db6def8)
#### Or create another user
![elevi_paoo2](https://github.com/AgacheAndrei/highSchoolManagement-project-app-C-Sharp-sql-PAOO/assets/36128809/8f2442bd-5b8b-437d-89cd-fc43383e4a62)
#### Main page called "Elevi" here you can:
![elevi_paoo3](https://github.com/AgacheAndrei/highSchoolManagement-project-app-C-Sharp-sql-PAOO/assets/36128809/ede5dd15-9cd0-4193-8625-31edf38f3749)
##### Show all students with scholarship (exist many types of scholarships) by pressing "Afisare Bursieri":
![elevi_paoo4](https://github.com/AgacheAndrei/highSchoolManagement-project-app-C-Sharp-sql-PAOO/assets/36128809/e448ff00-d98f-4b28-b794-ddaebcac8845)
##### Search after the "nr matricol" as key:
![elevi_paoo5](https://github.com/AgacheAndrei/highSchoolManagement-project-app-C-Sharp-sql-PAOO/assets/36128809/16138be7-c5c7-4eff-b135-e30a5859004e)
##### Filter students using their average score "medie" in ascending/descending order by pressing "Aplicare Filtre":
![elevi_paoo6](https://github.com/AgacheAndrei/highSchoolManagement-project-app-C-Sharp-sql-PAOO/assets/36128809/30c28d06-8772-48cb-ae4c-a6481fb274c4)
##### Delete student using the "nr matricol" as key by pressing "Delete":
##### Before
![elevi_paoo7](https://github.com/AgacheAndrei/highSchoolManagement-project-app-C-Sharp-sql-PAOO/assets/36128809/48a69c89-409b-45c3-959c-78e207700259)
##### After
![elevi_paoo8 png ](https://github.com/AgacheAndrei/highSchoolManagement-project-app-C-Sharp-sql-PAOO/assets/36128809/16c95148-0f91-401f-bf01-da88f2137120)

#### And buttons which will import/export the data, show all the students "Toti elevii", buttons which will send you to Update/Adaugare tabs
#### Insert page called "Adaugare" here you can add new students:
##### Before
![elevi_paoo9](https://github.com/AgacheAndrei/highSchoolManagement-project-app-C-Sharp-sql-PAOO/assets/36128809/7accca3b-0719-48ad-9bd5-7f9a2c765603)
##### After
![elevi_paoo10](https://github.com/AgacheAndrei/highSchoolManagement-project-app-C-Sharp-sql-PAOO/assets/36128809/76ade44c-bcba-42bc-8ef0-dedb619a045f)
![elevi_paoo11](https://github.com/AgacheAndrei/highSchoolManagement-project-app-C-Sharp-sql-PAOO/assets/36128809/db4a7598-822f-49c0-bf4b-8263e12dcfb4)
#### Update page called "Update" here you can update the info of the students:
##### Before: I will change the medie from 8.98 to 8.99
![elevi_paoo12](https://github.com/AgacheAndrei/highSchoolManagement-project-app-C-Sharp-sql-PAOO/assets/36128809/9896929f-b00f-44cf-a05d-e60284412a38)
##### After
![elevi_paoo13](https://github.com/AgacheAndrei/highSchoolManagement-project-app-C-Sharp-sql-PAOO/assets/36128809/fc9fe530-bc69-450e-9207-af7d481338df)
![elevi_paoo14](https://github.com/AgacheAndrei/highSchoolManagement-project-app-C-Sharp-sql-PAOO/assets/36128809/1b60e73f-2152-4b2c-a3f8-5ee33f0db9f9)
#### Graphs page called "Grafic" with important data: 
![elevi_paoo15](https://github.com/AgacheAndrei/highSchoolManagement-project-app-C-Sharp-sql-PAOO/assets/36128809/89dd3ee1-c746-4c62-8424-dbf5911ad0f3)
#### Scholarship students page called "Bursieri" with data about scholarship and students: 
![elevi_paoo16](https://github.com/AgacheAndrei/highSchoolManagement-project-app-C-Sharp-sql-PAOO/assets/36128809/01d1626b-79c3-4dcd-b092-ca1cf6d80d18)
#### Command history page called "Istoric" with data about who use the app and for what purpose: 
![elevi_paoo17](https://github.com/AgacheAndrei/highSchoolManagement-project-app-C-Sharp-sql-PAOO/assets/36128809/906d417e-5322-4fd9-bbb1-8536c544a46e)
#### Reports page called "Rapoarte" with reports on varios topics and can export/import the data in Excel format : 
![elevi_paoo18](https://github.com/AgacheAndrei/highSchoolManagement-project-app-C-Sharp-sql-PAOO/assets/36128809/1a776a29-eb48-4142-a7ea-13b48fefc2be)
##### Export the data:
![elevi_paoo19](https://github.com/AgacheAndrei/highSchoolManagement-project-app-C-Sharp-sql-PAOO/assets/36128809/3102d3e9-1f8a-4921-836a-b4fdfd399458)
![elevi_paoo20](https://github.com/AgacheAndrei/highSchoolManagement-project-app-C-Sharp-sql-PAOO/assets/36128809/ec7e7be0-49ae-4754-b6c5-0b5b2207666e)
##### Import the data:
##### Old data:
![elevi_paoo23](https://github.com/AgacheAndrei/highSchoolManagement-project-app-C-Sharp-sql-PAOO/assets/36128809/bcfc53e5-a8c7-46e0-b03f-19264606439b)
##### New data imported:
![elevi_paoo21](https://github.com/AgacheAndrei/highSchoolManagement-project-app-C-Sharp-sql-PAOO/assets/36128809/51c40ccb-d9af-40ac-ae20-d3c46cf9bf21)
![elevi_paoo22](https://github.com/AgacheAndrei/highSchoolManagement-project-app-C-Sharp-sql-PAOO/assets/36128809/c1218360-d648-487b-a890-c0159a46b1bd)
