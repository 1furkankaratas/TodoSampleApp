# :crystal_ball: Todo App :crystal_ball:
## Usage

![](https://raw.githubusercontent.com/1furkankaratas/TodoSampleApp/master/TodoAppUI/todoapp.jpg?token=ASIUT4PJTBAU4W4GIHYSXPDAVKNPS)
#### Step 1

Open DataAccess layer and Contrete>EntityFramework open in TodoContext.cs line 11 change connection string

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Change_Connection_String");
        }
    
#### Step 2　
Then open TodoAppUI folder and open index.html line 58 change your api address or port number .

    const Url = 'YOUR_API_ADdRESS:YourPortNumber/api/todos/';
