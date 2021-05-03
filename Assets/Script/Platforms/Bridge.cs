using System.Collections;
using Script.Platforms;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bridge : MonoBehaviour
{

    [SerializeField] private float m_startPoint, m_endPoint;
    [SerializeField] private float m_speed;
    [SerializeField] private Rigidbody m_rigidbody;
    [SerializeField] private float m_startPointWaitTime, m_endPointWaitTime;
    [SerializeField] private Direction m_direction;

    private bool m_state;

    private Vector2 m_startPosition
    {
        get
        {
            if (m_direction == Direction.Horizontal)
                return new Vector2(m_startPoint, 0);

            return new Vector2(0, m_startPoint);
        }
    }
    private Vector2 m_endPosition
    {
        get
        {
            if (m_direction == Direction.Horizontal)
                return new Vector2(m_endPoint, 0);

            return new Vector2(0, m_endPoint);
        }
    }

    private float m_length => Mathf.Abs(m_startPoint) + Mathf.Abs(m_endPoint);
    private float m_normalize;

    private WaitForSeconds m_waitingStartTime;
    private WaitForSeconds m_waitingEndTime;
    private WaitForFixedUpdate m_waitForFixedUpdade = new WaitForFixedUpdate();
    void Start()
    {
        m_waitingStartTime = new WaitForSeconds(m_startPointWaitTime);
        m_waitingEndTime = new WaitForSeconds(m_endPointWaitTime);
            
        StartCoroutine(Move());
    }

    private IEnumerator Move()
    {
        while (true)
        {
            m_normalize += Time.fixedDeltaTime / m_length * m_speed * (m_state ? -1 : 1);

            m_rigidbody.MovePosition(Vector2.Lerp(m_startPosition, m_endPosition, m_normalize));

            if (m_normalize <= 0)
            {
                m_state = false;
                yield return m_waitingStartTime;
            }
            else if (m_normalize >= 1f)
            {
                m_state = true;
                yield return m_waitingEndTime;
            }

            yield return m_waitForFixedUpdade;
        }
    }
}
