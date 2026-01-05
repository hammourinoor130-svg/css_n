async function UserInfo() {
        let response = await fetch("https://6947b569ca6715d122fadc09.mockapi.io/users");
        let data1 = await response.json();

        let tableBody = document.getElementById("usersBody");
        let rows = ""; 

        for (let i = 0; i < data.length; i++) {
            rows += "<tr>";
            rows += "<td>" + data1[i].id + "</td>";
            rows += "<td>" + data1[i].name + "</td>";
            rows += "<td>" + data1[i].email + "</td>";
             rows += "<td>" + data1[i].password + "</td>";
            rows += "<td><img src='" + data1[i].avatar + "' width='50'></td>";
            rows += "</tr>";
        }

        tableBody.innerHTML = rows;
    }

    ();