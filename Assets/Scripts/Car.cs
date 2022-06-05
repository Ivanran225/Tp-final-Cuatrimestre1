using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{ 
	//Variables de los imputs
	private float horizontalInput;
	private float verticalInput;
	private float steeringAngle;
	//Variables para insertar todos los objetos
	public WheelCollider FL, FR;
	public WheelCollider RL, RR;
	public Transform TransofrmFL, TransformFR;
	public Transform TransofrmRL, TransofrmRR;
	//Variables de cuanta fuerza tiene el motor y cuanto giran las ruuedas
	public float maxSteerAngle = 30;
	public float motorForce = 50;

	//Se toman las variables como get axis asi se puede acelerar y frenar o girar para ambos lados con 1 sola variable, ya que get axis es un valor de -1 a 1
	public void Angulo()
	{
		horizontalInput = Input.GetAxis("Horizontal");
		verticalInput = Input.GetAxis("Vertical");
	}
	//Esta fucnion aplica los valores de los get axis a los wheel colider
	private void Steer()
	{
		steeringAngle = maxSteerAngle * horizontalInput;
		//.sterAngle por que el motor de fisica tiene problemas con los float
		FL.steerAngle = steeringAngle;
		FR.steerAngle = steeringAngle;
	}
	//Aceleracion lo mismo que Steer
	private void Acelera()
	{
		RL.motorTorque = verticalInput * motorForce;
		RR.motorTorque = verticalInput * motorForce;
	}
	//Esta funcion toma la poscion de los wheel coliders y las aplica a los meshes de las ruedas
	private void GetPosicionRuedas(WheelCollider collider, Transform transform)
	{
		Vector3 pos = transform.position;
		Quaternion quat = transform.rotation;

		collider.GetWorldPose(out pos, out quat);

		transform.position = pos;
		transform.rotation = quat;
	}
	//Este es el imput para GetPosicionRuedas
	private void PosicionRuedas()
	{
		GetPosicionRuedas(FL, TransofrmFL);
		GetPosicionRuedas(FR, TransformFR);
		GetPosicionRuedas(RL, TransofrmRL);
		GetPosicionRuedas(RR, TransofrmRR);
	}
	//Final
	private void FixedUpdate()
	{
		Angulo();
		Steer();
		Acelera();
		PosicionRuedas();
	}
}