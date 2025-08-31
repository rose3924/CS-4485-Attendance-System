#  :bookmark_tabs: Web-Based Attendance Management System
An attendance management system composed of a web-based student portal paired with a desktop app for professors. 

#### Features Include : 
- Secure login for both students and professors  
- Course management (create, view, and edit courses) for professors
- Quiz creation and management for each course
- CSV import to upload class rosters via the desktop app
- Attendance tracking tied to daily quiz/password entry
- Quiz submission records student IP to prevent duplicate or fraudulent submissions
- Late / excused absence handling  
- Attendance reports exportable for professor review  

## :hammer_and_wrench: Tools & Technologies
- **Languages:** C#, SQL  
- **Frameworks:** WinForms, Blazor  
- **Database:** Azure SQL, DBeaver (for management)  
- **Version Control:** GitHub  
- **IDE:** Visual Studio

## :bulb: Why Create Such A System?
Professors at The University of Texas at Dallas (UTD) lack an efficient system to mark students present for their course. Some resort to swiping student identification cards at the beginning of the course but this method can waste significant class time in courses with 40+ students while requiring additional professor attention for late arrivals. The competing method on campus includes creating attendance quizzes on eLearning (the UTD preferred learning platform for course management), yet this method can clutter eLearning with 25+ assignments all dedicated to attendance.

With a web-based system tied to a desktop app, professors will be able to take accurate attendance without eating up class time or cluttering their eLearning. With the added features mentioned previously!
<br>
<br>

##  :computer: Professor Desktop App 
### Built with: WinForms, C#

<img alt="Login_Screen" src="https://github.com/user-attachments/assets/ca0b1600-0f35-4ef7-9adc-06ae73133609" width="500" />

*Figure 1. Professor Login Screen*

<br>

<img alt="Courses_Screen" src="https://github.com/user-attachments/assets/f9e27e43-c101-46bd-82b6-7e632c3487f5" width="500" />

*Figure 2. Courses Overview Screen*

<br>

<img alt="Course_Home_Screen" src="https://github.com/user-attachments/assets/90b5edc1-88bb-4505-b8f0-bec2d9555931" width="500" />

*Figure 3. Course Home Screen*

<br>

<img alt="Create_Course_Screen" src="https://github.com/user-attachments/assets/e2b15e31-ba69-49e3-b561-740c79ffd46f" width="400" />

*Figure 4. Create Course Form*

<br>

##  :globe_with_meridians: Student Web Browser Page 
### Built with Blazor, C#
- :computer: Students log in securely with UTD credentials  
- :calendar: Professors post daily attendance quizzes  
- :clock4: Attendance submissions tied to session times  
- :link: Synced with the professor’s desktop app  

<img alt="Student_Login" src="https://github.com/user-attachments/assets/9b61478e-1c38-4cdb-8a75-da8d50cc2188" width="500" />

*Figure 5. Student Login Screen*

<br>

<img alt="Student_Quiz" src ="https://github.com/user-attachments/assets/622dd80e-42cb-4cbb-a7cc-e8ad1ee67114" width="500" />

*Figure 6. Sample Student Quiz Page*


<br>

## :cloud::no_entry_sign: Azure SQL Cloud Database Discontinued
This system was originally deployed with an **Azure SQL Cloud Database**, which has since been discontinued/deleted (as of May 2025) due to hosting costs.  

The front-end (WinForms desktop app + Blazor web app) code remains available in this repository for review, but the system cannot be run without re-establishing a backend database connection.  

This project is preserved for **portfolio and academic purposes**.
