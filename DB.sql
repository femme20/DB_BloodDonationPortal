-- DROP TABLES IF EXISTS (Safe re-execution)
DROP TABLE IF EXISTS Feedback, DonationHistory, Inventory, BloodRequest, Appointment, Campaign, Patient, Donor, Doctor, Hospital, DonationCenter, Admin;

-- 1. Admin Table
CREATE TABLE Admin (
    AdminID INT PRIMARY KEY IDENTITY(1,1),
    Username VARCHAR(50) NOT NULL,
    PasswordHash VARCHAR(255) NOT NULL
);

-- 2. Donation Center
CREATE TABLE DonationCenter (
    CenterID INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(100) NOT NULL,
    Location VARCHAR(200),
    ContactNumber VARCHAR(20)
);

-- 3. Hospital
CREATE TABLE Hospital (
    HospitalID INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(100) NOT NULL,
    Address VARCHAR(200),
    Phone VARCHAR(20)
);

-- 4. Doctor
CREATE TABLE Doctor (
    DoctorID INT PRIMARY KEY IDENTITY(1,1),
    FullName VARCHAR(100),
    Specialty VARCHAR(100),
    HospitalID INT,
    FOREIGN KEY (HospitalID) REFERENCES Hospital(HospitalID)
);

-- 5. Donor
CREATE TABLE Donor (
    DonorID INT PRIMARY KEY IDENTITY(1,1),
    FullName VARCHAR(100),
    BloodType VARCHAR(5) CHECK (BloodType IN ('A+', 'A-', 'B+', 'B-', 'AB+', 'AB-', 'O+', 'O-')),
    Age INT CHECK (Age >= 18),
    Gender VARCHAR(10),
    Phone VARCHAR(20)
);

-- 6. Patient
CREATE TABLE Patient (
    PatientID INT PRIMARY KEY IDENTITY(1,1),
    FullName VARCHAR(100),
    BloodType VARCHAR(5),
    HospitalID INT,
    FOREIGN KEY (HospitalID) REFERENCES Hospital(HospitalID)
);

-- 7. Campaign
CREATE TABLE Campaign (
    CampaignID INT PRIMARY KEY IDENTITY(1,1),
    Title VARCHAR(100),
    Date DATE,
    CenterID INT,
    FOREIGN KEY (CenterID) REFERENCES DonationCenter(CenterID)
);

-- 8. Appointment
CREATE TABLE Appointment (
    AppointmentID INT PRIMARY KEY IDENTITY(1,1),
    DonorID INT,
    CenterID INT,
    AppointmentDate DATE,
    Status VARCHAR(20),
    FOREIGN KEY (DonorID) REFERENCES Donor(DonorID),
    FOREIGN KEY (CenterID) REFERENCES DonationCenter(CenterID)
);

-- 9. Blood Request
CREATE TABLE BloodRequest (
    RequestID INT PRIMARY KEY IDENTITY(1,1),
    PatientID INT,
    RequestedDate DATE,
    BloodType VARCHAR(5),
    Quantity INT,
    Status VARCHAR(50),
    FOREIGN KEY (PatientID) REFERENCES Patient(PatientID)
);

-- 10. Inventory
CREATE TABLE Inventory (
    InventoryID INT PRIMARY KEY IDENTITY(1,1),
    CenterID INT,
    BloodType VARCHAR(5),
    QuantityAvailable INT,
    FOREIGN KEY (CenterID) REFERENCES DonationCenter(CenterID)
);

-- 11. Donation History
CREATE TABLE DonationHistory (
    HistoryID INT PRIMARY KEY IDENTITY(1,1),
    DonorID INT,
    DateOfDonation DATE,
    BloodType VARCHAR(5),
    CenterID INT,
    FOREIGN KEY (DonorID) REFERENCES Donor(DonorID),
    FOREIGN KEY (CenterID) REFERENCES DonationCenter(CenterID)
);

-- 12. Feedback
CREATE TABLE Feedback (
    FeedbackID INT PRIMARY KEY IDENTITY(1,1),
    DonorID INT,
    Comments TEXT,
    Rating INT CHECK (Rating BETWEEN 1 AND 5),
    FOREIGN KEY (DonorID) REFERENCES Donor(DonorID)
);

INSERT INTO DonationCenter (Name, Location, ContactNumber) VALUES
('City Blood Center', 'Downtown Block A', '123-456-7890'),
('RedDrop Center', 'Main Street 42', '234-567-8901'),
('LifeStream Center', 'Hilltop Road', '345-678-9012'),
('PulsePoint', 'Sector 9 Market', '456-789-0123'),
('Hope Donor House', 'Green Valley', '567-890-1234'),
('VitalLife Blood Bank', 'Tech City', '678-901-2345'),
('Unity Blood Center', 'Hospital Road', '789-012-3456'),
('BloodBridge', 'Elm Avenue', '890-123-4567'),
('DonorNest', 'West End Plaza', '901-234-5678'),
('SaveALife Center', 'East Boulevard', '012-345-6789'),
('RedLine Donors', 'Park Street', '111-222-3333'),
('LifeGivers Point', 'North Junction', '222-333-4444'),
('HopeCircle Center', 'Medical Lane', '333-444-5555'),
('Sunrise Donation Hub', 'Airport Road', '444-555-6666'),
('BloodTrust Bank', 'South Hillside', '555-666-7777');


INSERT INTO Hospital (Name, Address, Phone) VALUES
('City General Hospital', 'Downtown Avenue', '111-555-9999'),
('Sunshine Hospital', 'Hill View Street', '222-666-8888'),
('Hope Medical Center', 'Lakefront Blvd', '333-777-9999'),
('GoodHealth Hospital', 'Sector 12', '444-888-7777'),
('Unity Hospital', 'Near Central Park', '555-999-6666'),
('LifeCare Hospital', 'Metro Town', '666-444-3333'),
('Central Blood Hospital', 'Midland Zone', '777-333-2222'),
('Healers Hospital', 'Near City Mall', '888-222-1111'),
('St. Mercy Hospital', 'Hospital Lane', '999-111-0000'),
('Rapid Response Hospital', 'Main Road 99', '121-212-1212'),
('Medico Hospital', 'Rose Garden', '131-313-1313'),
('Galaxy Hospital', 'Satellite Road', '141-414-1414'),
('Zion Hospital', 'Tech Park View', '151-515-1515'),
('BrightCare Hospital', 'Skyline Avenue', '161-616-1616'),
('Trinity Health', 'Old Bridge Street', '171-717-1717');

INSERT INTO Doctor (FullName, Specialty, HospitalID) VALUES
('Dr. Sara Khan', 'Hematology', 1),
('Dr. Rehan Ali', 'Emergency Medicine', 2),
('Dr. Ayesha Noor', 'Pathology', 3),
('Dr. Kamran Raza', 'Internal Medicine', 4),
('Dr. Mehak Tariq', 'Oncology', 5),
('Dr. Waqas Saeed', 'Transfusion Medicine', 6),
('Dr. Nida Ahmed', 'General Surgery', 7),
('Dr. Faizan Qureshi', 'Family Medicine', 8),
('Dr. Rabia Malik', 'Internal Medicine', 9),
('Dr. Zainab Khan', 'Hematology', 10),
('Dr. Saad Baig', 'ER Specialist', 11),
('Dr. Mahnoor Yousaf', 'Diagnostics', 12),
('Dr. Imran Farooq', 'Blood Banking', 13),
('Dr. Aleena Mirza', 'Medical Officer', 14),
('Dr. Omer Nasir', 'Transfusion Expert', 15);


INSERT INTO Donor (FullName, BloodType, Age, Gender, Phone) VALUES
('Ali Raza', 'A+', 25, 'Male', '0300-1234567'),
('Fatima Noor', 'B+', 28, 'Female', '0301-2345678'),
('Hassan Khan', 'O+', 30, 'Male', '0302-3456789'),
('Sara Ahmed', 'AB+', 22, 'Female', '0303-4567890'),
('Usman Tariq', 'O-', 35, 'Male', '0304-5678901'),
('Zara Saeed', 'B-', 27, 'Female', '0305-6789012'),
('Bilal Qureshi', 'A-', 29, 'Male', '0306-7890123'),
('Hina Shahid', 'AB-', 24, 'Female', '0307-8901234'),
('Waleed Anwar', 'B+', 33, 'Male', '0308-9012345'),
('Maryam Iqbal', 'O+', 26, 'Female', '0309-0123456'),
('Tariq Mehmood', 'A+', 40, 'Male', '0310-1234567'),
('Areeba Malik', 'B+', 23, 'Female', '0311-2345678'),
('Ahmed Nadeem', 'O-', 31, 'Male', '0312-3456789'),
('Sana Javed', 'AB+', 22, 'Female', '0313-4567890'),
('Zeeshan Akram', 'A-', 34, 'Male', '0314-5678901');


INSERT INTO Patient (FullName, BloodType, HospitalID) VALUES
('Imran Ali', 'A+', 1),
('Nadia Ahmed', 'B+', 2),
('Omer Shah', 'O-', 3),
('Hira Saeed', 'AB+', 4),
('Salman Tariq', 'B-', 5),
('Mehwish Khan', 'A-', 6),
('Azhar Jameel', 'O+', 7),
('Fiza Rauf', 'B+', 8),
('Jawad Malik', 'AB-', 9),
('Laiba Anwar', 'A+', 10),
('Asad Zafar', 'B+', 11),
('Amina Hassan', 'O-', 12),
('Hassan Iqbal', 'A-', 13),
('Sadia Naveed', 'AB+', 14),
('Noman Yousuf', 'O+', 15);


INSERT INTO Campaign (Title, Date, CenterID) VALUES
('Save Lives Campaign', '2025-01-15', 1),
('Blood Drive 2025', '2025-02-10', 2),
('Red Drop Initiative', '2025-03-05', 3),
('Donate for Hope', '2025-04-20', 4),
('Life Givers Event', '2025-05-10', 5),
('Blood for All', '2025-06-01', 6),
('Hope in a Bag', '2025-06-15', 7),
('Heroes Needed', '2025-07-01', 8),
('Gift of Life', '2025-07-15', 9),
('One Pint Saves Lives', '2025-08-01', 10),
('Be a Donor', '2025-08-20', 11),
('Donate to Celebrate', '2025-09-10', 12),
('Unity in Blood', '2025-09-25', 13),
('Every Drop Counts', '2025-10-05', 14),
('Together We Save', '2025-10-20', 15);

INSERT INTO Appointment (DonorID, CenterID, AppointmentDate, Status) VALUES
(1, 1, '2025-06-01', 'Confirmed'),
(2, 2, '2025-06-02', 'Completed'),
(3, 3, '2025-06-03', 'Pending'),
(4, 4, '2025-06-04', 'Cancelled'),
(5, 5, '2025-06-05', 'Confirmed'),
(6, 6, '2025-06-06', 'Completed'),
(7, 7, '2025-06-07', 'Confirmed'),
(8, 8, '2025-06-08', 'Pending'),
(9, 9, '2025-06-09', 'Confirmed'),
(10, 10, '2025-06-10', 'Completed'),
(11, 11, '2025-06-11', 'Cancelled'),
(12, 12, '2025-06-12', 'Confirmed'),
(13, 13, '2025-06-13', 'Pending'),
(14, 14, '2025-06-14', 'Completed'),
(15, 15, '2025-06-15', 'Confirmed');

INSERT INTO BloodRequest (PatientID, RequestedDate, BloodType, Quantity, Status) VALUES
(1, '2025-06-01', 'A+', 2, 'Pending'),
(2, '2025-06-02', 'B+', 1, 'Approved'),
(3, '2025-06-03', 'O-', 3, 'Rejected'),
(4, '2025-06-04', 'AB+', 2, 'Pending'),
(5, '2025-06-05', 'B-', 1, 'Approved'),
(6, '2025-06-06', 'A-', 2, 'Pending'),
(7, '2025-06-07', 'O+', 1, 'Approved'),
(8, '2025-06-08', 'AB-', 2, 'Rejected'),
(9, '2025-06-09', 'A+', 2, 'Pending'),
(10, '2025-06-10', 'B+', 3, 'Approved'),
(11, '2025-06-11', 'O-', 1, 'Rejected'),
(12, '2025-06-12', 'A-', 2, 'Approved'),
(13, '2025-06-13', 'AB+', 3, 'Pending'),
(14, '2025-06-14', 'O+', 1, 'Approved'),
(15, '2025-06-15', 'B-', 2, 'Pending');

INSERT INTO Inventory (CenterID, BloodType, QuantityAvailable) VALUES
(1, 'A+', 10),
(2, 'B+', 8),
(3, 'O-', 6),
(4, 'AB+', 4),
(5, 'B-', 5),
(6, 'A-', 7),
(7, 'O+', 12),
(8, 'AB-', 3),
(9, 'A+', 6),
(10, 'B+', 9),
(11, 'O-', 4),
(12, 'A-', 8),
(13, 'AB+', 7),
(14, 'O+', 10),
(15, 'B-', 6);

INSERT INTO DonationHistory (DonorID, DateOfDonation, BloodType, CenterID) VALUES
(1, '2025-01-01', 'A+', 1),
(2, '2025-01-15', 'B+', 2),
(3, '2025-02-01', 'O-', 3),
(4, '2025-02-15', 'AB+', 4),
(5, '2025-03-01', 'B-', 5),
(6, '2025-03-15', 'A-', 6),
(7, '2025-04-01', 'O+', 7),
(8, '2025-04-15', 'AB-', 8),
(9, '2025-05-01', 'A+', 9),
(10, '2025-05-15', 'B+', 10),
(11, '2025-06-01', 'O-', 11),
(12, '2025-06-15', 'A-', 12),
(13, '2025-07-01', 'AB+', 13),
(14, '2025-07-15', 'O+', 14),
(15, '2025-08-01', 'B-', 15);


INSERT INTO Feedback (DonorID, Comments, Rating) VALUES
(1, 'Great service!', 5),
(2, 'Friendly staff.', 4),
(3, 'Quick and clean process.', 5),
(4, 'Need better seating.', 3),
(5, 'Loved the volunteers.', 5),
(6, 'It was okay.', 3),
(7, 'Very professional.', 4),
(8, 'Long wait time.', 2),
(9, 'Amazing work.', 5),
(10, 'Could be cleaner.', 3),
(11, 'Smooth experience.', 4),
(12, 'Nice and efficient.', 4),
(13, 'Uncomfortable chairs.', 2),
(14, 'Staff was kind.', 5),
(15, 'Overall great.', 4);


USE DB; 
GO

------------------ DonationCenter ------------------
-- Create
INSERT INTO DonationCenter (Name, Location, ContactNumber)
VALUES ('New Life Center', 'River Street', '0333-5554444');

-- Read
SELECT * FROM DonationCenter;

-- Update
UPDATE DonationCenter
SET ContactNumber = '0333-9999999'
WHERE CenterID = 1;

-- Delete
DELETE FROM DonationCenter
WHERE CenterID = 15;


------------------ Hospital ------------------
-- Create
INSERT INTO Hospital (Name, Address, Phone)
VALUES ('Healthy Hospital', 'East Block', '0444-2223333');

-- Read
SELECT * FROM Hospital;

-- Update
UPDATE Hospital
SET Phone = '0444-8888888'
WHERE HospitalID = 1;

-- Delete
DELETE FROM Hospital
WHERE HospitalID = 15;


------------------ Doctor ------------------
-- Create
INSERT INTO Doctor (FullName, Specialty, HospitalID)
VALUES ('Dr. Khalid Mehmood', 'Cardiology', 1);

-- Read
SELECT * FROM Doctor;

-- Update
UPDATE Doctor
SET Specialty = 'Hematology'
WHERE DoctorID = 1;

-- Delete
DELETE FROM Doctor
WHERE DoctorID = 15;


------------------ Donor ------------------
-- Create
INSERT INTO Donor (FullName, BloodType, Age, Gender, Phone)
VALUES ('Nida Aslam', 'O-', 27, 'Female', '0322-4445566');

-- Read
SELECT * FROM Donor;

-- Update
UPDATE Donor
SET Phone = '0322-0000000'
WHERE DonorID = 1;

-- Delete
DELETE FROM Donor
WHERE DonorID = 15;


------------------ Patient ------------------
-- Create
INSERT INTO Patient (FullName, BloodType, HospitalID)
VALUES ('Hamza Saeed', 'AB-', 2);

-- Read
SELECT * FROM Patient;

-- Update
UPDATE Patient
SET FullName = 'Hamza Khan'
WHERE PatientID = 1;

-- Delete
DELETE FROM Patient
WHERE PatientID = 15;


------------------ Campaign ------------------
-- Create
INSERT INTO Campaign (Title, Date, CenterID)
VALUES ('Blood Warriors 2025', '2025-12-01', 3);

-- Read
SELECT * FROM Campaign;

-- Update
UPDATE Campaign
SET Title = 'Blood Warriors Drive'
WHERE CampaignID = 1;

-- Delete
DELETE FROM Campaign
WHERE CampaignID = 15;


------------------ Appointment ------------------
-- Create
INSERT INTO Appointment (DonorID, CenterID, AppointmentDate, Status)
VALUES (1, 2, '2025-12-10', 'Confirmed');

-- Read
SELECT * FROM Appointment;

-- Update
UPDATE Appointment
SET Status = 'Completed'
WHERE AppointmentID = 1;

-- Delete
DELETE FROM Appointment
WHERE AppointmentID = 15;


------------------ BloodRequest ------------------
-- Create
INSERT INTO BloodRequest (PatientID, RequestedDate, BloodType, Quantity, Status)
VALUES (2, '2025-12-12', 'B+', 2, 'Pending');

-- Read
SELECT * FROM BloodRequest;

-- Update
UPDATE BloodRequest
SET Status = 'Approved'
WHERE RequestID = 1;

-- Delete
DELETE FROM BloodRequest
WHERE RequestID = 15;


------------------ Inventory ------------------
-- Create
INSERT INTO Inventory (CenterID, BloodType, QuantityAvailable)
VALUES (4, 'A+', 5);

-- Read
SELECT * FROM Inventory;

-- Update
UPDATE Inventory
SET QuantityAvailable = 15
WHERE InventoryID = 1;

-- Delete
DELETE FROM Inventory
WHERE InventoryID = 15;


------------------ DonationHistory ------------------
-- Create
INSERT INTO DonationHistory (DonorID, DateOfDonation, BloodType, CenterID)
VALUES (3, '2025-11-20', 'O-', 2);

-- Read
SELECT * FROM DonationHistory;

-- Update
UPDATE DonationHistory
SET DateOfDonation = '2025-11-25'
WHERE HistoryID = 1;

-- Delete
DELETE FROM DonationHistory
WHERE HistoryID = 15;


------------------ Feedback ------------------
-- Create
INSERT INTO Feedback (DonorID, Comments, Rating)
VALUES (5, 'Very smooth process.', 5);

-- Read
SELECT * FROM Feedback;

-- Update
UPDATE Feedback
SET Rating = 4
WHERE FeedbackID = 1;

-- Delete
DELETE FROM Feedback
WHERE FeedbackID = 15;

SELECT name 
FROM sys.tables;

SELECT * FROM Admin;
SELECT * FROM Donor;
SELECT * FROM BloodRequest;
SELECT * FROM DonationHistory;
SELECT * FROM Hospital;
SELECT * FROM Inventory;
SELECT * FROM DonationCenter;
SELECT * FROM Appointment;
SELECT * FROM Doctor;
SELECT * FROM Feedback;
SELECT * FROM Patient;
SELECT * FROM Campaign;

