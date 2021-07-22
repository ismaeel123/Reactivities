import React from "react";
import { Grid} from "semantic-ui-react";
import { Activity } from "../../../App/Models/Activities";
import ActivityDetail from "../activityDetails/ActivityDetails";
import ActivityForm from "../form/ActivityForm";
import ActivityList from "./ActivityList";

interface Props{
    activities:Activity[];
    selectedActivity: Activity | undefined;
    selectActivity  : (id: string) => void
    cancelSelectActivity : () =>void
    editMode : boolean
    openForm : (id :string) =>void
    closeForm : () =>void;  
    editOrCreate: (activity :Activity) =>void; 
    deleteActivity : (id:string) =>void
}

export default function ActivityDashboard ({activities,selectedActivity,selectActivity,cancelSelectActivity,
editMode,openForm,closeForm,editOrCreate,deleteActivity}: Props){
    return (
        <Grid>
            <Grid.Column width='10'>
                <ActivityList activities={activities} 
                selectActivity= {selectActivity}
                deleteActivity= {deleteActivity}
                />
            </Grid.Column>
            <Grid.Column width='6'>
                {selectedActivity && !editMode &&
                <ActivityDetail 
                activity={selectedActivity}
                cancelSelectActivity= {cancelSelectActivity}
                openForm = {openForm}
                />}
                {editMode &&
                <ActivityForm closeForm ={closeForm}
                activity={selectedActivity}
                editOrCreate= {editOrCreate} 
                 />}
            </Grid.Column>
        </Grid>
    )
}