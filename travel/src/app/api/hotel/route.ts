import { NextResponse } from "next/server";

export async function GET(){
    try {
    } catch (error) {
        return NextResponse.json({error: "Something went wrong!"}, {status: 500})
    }
}