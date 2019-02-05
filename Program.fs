open System


let doing_functions() =

     let sum (x:int, y:int) : int = x+y; //creates a function and a return type of int being x +y

     printfn "2 +10 is %i"(sum(2,10))


     let rand_list = [3;4;5]// creates a list and fills it with 123

     // for every item that is in rand_list(1,2,3), it is multiplied by 2

     let rand_list2 = List.map (fun x -> x*2) rand_list//lambda expression
     printfn"Double List: %A" rand_list2

     [12;8;9;10]
     |> List.filter (fun v-> (v % 2)=0) // goes through the list and finds the even numbers
     |> List.map (fun x -> x*2)//multiplies the even numbers by 2
     |>printfn "The even numbers multiplied by 2 are: %A" 


doing_functions()

Console.ReadKey() |> ignore
