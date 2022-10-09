using UnityEngine;

interface ITriggerEnter
{
    public void OnEnter(GameObject player , GameObject gameObject);

}
interface ITriggerStay
{
    public void OnStay(GameObject player , GameObject gameObject);

}
interface ITriggerExit
{
    public void OnExit(GameObject player , GameObject gameObject);
}
