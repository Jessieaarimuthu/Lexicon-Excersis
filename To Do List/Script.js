const taskList = document.getElementById("task-list");
      const addTaskForm = document.getElementById("add-task-form");
      const newTaskInput = document.getElementById("new-task-input");

      let tasks = [];

      function renderTasks() {
        taskList.innerHTML = "";

        for (let i = 0; i < tasks.length; i++) {
          const task = tasks[i];

          const taskElement = document.createElement("li");
          taskElement.className = "task";

          const checkboxElement = document.createElement("input");
          checkboxElement.type = "checkbox";
          checkboxElement.checked = task.completed;

          const textInputElement = document.createElement("input");
          textInputElement.type = "text";
          textInputElement.value = task.text;

          const deleteButtonElement = document.createElement("button");
          deleteButtonElement.textContent = "Delete";

          taskElement.appendChild(checkboxElement);
          taskElement.appendChild(textInputElement);
          taskElement.appendChild(deleteButtonElement);

          taskList.appendChild(taskElement);

          checkboxElement.addEventListener("change", () => {
            task.completed = checkboxElement.checked;
            renderTasks();
          });

          textInputElement.addEventListener("change", () => {
            task.text = textInputElement.value;
            renderTasks();
          });

          deleteButtonElement.addEventListener("click", () => {
            tasks.splice(i, 1);
            renderTasks();
          });
        }
      }

      addTaskForm.addEventListener("submit", event => {
        event.preventDefault();

        const newTaskText = newTaskInput.value.trim();

        if (newTaskText) {
          tasks.push({
            text: newTaskText,
            completed: false
          });

          newTaskInput.value = "";

          renderTasks();
        }
      });
