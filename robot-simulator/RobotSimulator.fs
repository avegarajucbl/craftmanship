module RobotSimulator

type Direction = North | East | South | West
type Position = int * int
type Robot = { direction: Direction; position: Position }
let create direction position = failwith "implement the function"

let move (instructions: string) robot = failwith "implement the function"
    
    