create procedure sp_RecordExamMarks (@examId int, @studentId int,@marksObtained int)
as
begin
begin transaction
begin try
insert into Marks(StudentID,ExamID,MarksObtained)
values(@studentId,@examId,@marksObtained)
update Exams set ExamDate=GETDATE()  where ExamID=@examId
commit transaction
print 'Success: Marks inserted and Exam record updated.'
end try
begin catch
rollback transaction
print 'Transaction Failed! All changes have been undone.'
print 'Error Message: '+ERROR_MESSAGE()
end catch
end

exec sp_RecordExamMarks 101, 1, 85;
